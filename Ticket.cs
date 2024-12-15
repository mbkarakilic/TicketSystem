using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSystem.Models;

namespace TicketSystem
{
	public partial class Ticket : Form
	{
		private TicketOwner owner;
		private Travel travel;

		private string activePnr;
		public Ticket()
		{
			InitializeComponent();
		}

		private void searchButton_Click(object sender, EventArgs e)
		{
			string pnr = pnrTextbox.Text;  // Textbox'tan PNR numarasını al
			try
			{
				// Veritabanı bağlantısını al
				DatabaseHelper db = DatabaseHelper.GetInstance();
				SQLiteConnection connection = db.GetConnection();
				SQLiteCommand command = db.GetCommand();

				connection.Open();

				// SQL sorgusunu hazırla
				string query = @"
            SELECT 
                t.id AS ticket_id, 
                t.owner_name, 
                t.owner_surname, 
                t.owner_phone_number, 
                t.owner_mail, 
                t.owner_gender, 
                t.seat_number, 
                t.pnr, 
                tr.*
            FROM 
                tickets t
            INNER JOIN 
                travels tr ON t.travel_id = tr.id
            WHERE 
                t.pnr = @pnr;";

				command.CommandText = query;
				command.Parameters.Clear();
				command.Parameters.AddWithValue("@pnr", pnr);  // PNR'yı parametre olarak ekle

				SQLiteDataReader reader = command.ExecuteReader();

				// Veriler varsa, okuma işlemi yapılır
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						// Bilet bilgilerini al
						int seat_number = reader.GetInt32(reader.GetOrdinal("seat_number"));
						int owner_gender = reader.GetInt32(reader.GetOrdinal("owner_gender"));
						string owner_name = reader.GetString(reader.GetOrdinal("owner_name"));
						string owner_surname = reader.GetString(reader.GetOrdinal("owner_surname"));
						string owner_phone_number = reader.GetString(reader.GetOrdinal("owner_phone_number"));
						string owner_mail = reader.GetString(reader.GetOrdinal("owner_mail"));
						string pnrFromDb = reader.GetString(reader.GetOrdinal("pnr"));

						owner = new TicketOwner(owner_name, owner_surname, owner_mail, owner_phone_number, owner_gender, seat_number);

						// Seyahat bilgilerini al
						int travel_id = reader.GetInt32(reader.GetOrdinal("id"));
						string from = reader.GetString(reader.GetOrdinal("from"));
						string to = reader.GetString(reader.GetOrdinal("to"));
						string date = reader.GetString(reader.GetOrdinal("date"));
						string time = reader.GetString(reader.GetOrdinal("time"));
						string company = reader.GetString(reader.GetOrdinal("company"));
						double price = reader.GetDouble(reader.GetOrdinal("price"));

						travel = new Travel(travel_id, from, to, company, price, date, time, null);

						activePnr = pnrFromDb;
						ShowTicketInfo(owner, travel);
					}
				}
				else
				{
					// PNR bulunamadığında kullanıcıya mesaj göster
					MessageBox.Show("Bilet bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				reader.Close();
				connection.Close();
			}
			catch (Exception ex)
			{
				// Hata durumunda hata mesajını yazdır
				Console.WriteLine($"Hata: {ex.Message}");
				MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ShowTicketInfo(TicketOwner owner, Travel travel)
		{
			fromLabel.Text = travel.From;

			toLabel.Text = travel.To;

			dateLabel.Text = travel.Date;

			timeLabel.Text = travel.Time;

			priceLabel.Text = travel.Price + "";

			pnrLabel.Text = activePnr;

			seatNumberLabel.Text = owner.SeatNumber + "";

			companyLabel.Text = travel.Company;

			panel1.Visible = false;
		}

		private void DeleteButtonOnClick(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
		"Bu bileti iptal etmek istediğinizden emin misiniz?",
		"Bileti İptal Et",
		MessageBoxButtons.YesNo,
		MessageBoxIcon.Warning
	);

			if (result == DialogResult.Yes)
			{
				DatabaseHelper db = DatabaseHelper.GetInstance();

				SQLiteConnection connection = db.GetConnection();
				SQLiteCommand command = db.GetCommand();
				connection.Open();
				try
				{
					string query = "DELETE FROM tickets WHERE pnr = @pnr";
					command.CommandText = query;
					command.Parameters.AddWithValue("@pnr", activePnr);

					int rowsAffected = command.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						MessageBox.Show("Bilet başarıyla iptal edildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

						panel1.Visible = true;
						pnrTextbox.Text = "";
						owner = null;
						travel = null;
					}
					else
					{
						MessageBox.Show("İptal edilecek bilet bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Bir Hata Oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
					Console.WriteLine(ex.Message);
				}
				connection.Close();
			}
			else
			{
				// İşlem iptal edildi
				MessageBox.Show("İptal etme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
