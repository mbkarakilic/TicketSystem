using System.Data.SQLite;
using System.Windows.Forms;
using TicketSystem.Models;

namespace TicketSystem
{
	public partial class AdminPanel : Form
	{
		private int type;
		private List<Travel> travels;
		private List<int> vehicleIds;
		private int selectedRow;

		private AddTravel addTravel;
		public AdminPanel()
		{
			type = -1;
			vehicleIds = new List<int>();
			travels = new List<Travel>();
			InitializeComponent();
		}

		private void SearchButtonOnClick(object sender, EventArgs e)
		{
			if (fromComboBox.Text.Equals("") || toComboBox.Equals("") || typeComboBox.Equals(""))
			{
				errorText.Visible = true;
				return;
			}

			errorText.Visible = false;

			travelsGrid.Visible = false;
			travelsGrid.Rows.Clear();

			Console.WriteLine(dateTimePicker.Text);
			string[] dateParts = dateTimePicker.Text.Split('.'); // "." ile böl
			Array.Reverse(dateParts); // Diziyi ters çevir
			string dateSelected = string.Join("-", dateParts); // "-" ile birleştir

			travels.Clear();
			vehicleIds.Clear();

			DatabaseHelper db = DatabaseHelper.GetInstance();

			SQLiteConnection connection = db.GetConnection();
			SQLiteCommand command = db.GetCommand();

			connection.Open();

			#region Buses
			string q1 = "SELECT Id FROM vehicles WHERE class = @type";
			command.CommandText = q1;
			command.Parameters.AddWithValue("@type", typeComboBox.SelectedIndex);

			SQLiteDataReader reader1 = command.ExecuteReader();

			if (reader1.HasRows)
			{
				while (reader1.Read())
				{
					int id = reader1.GetInt32(reader1.GetOrdinal("Id"));

					vehicleIds.Add(id);
				}
			}
			reader1.Close();
			#endregion

			#region Travels

			string query = @"
    SELECT 
        travels.*,
        vehicles.brand,
        vehicles.type
    FROM 
        travels
    INNER JOIN 
        vehicles 
    ON 
        travels.vehicle_id = vehicles.Id
    WHERE 
        travels.vehicle_id = @id 
        AND travels.[from] = @from 
        AND travels.[to] = @to
		AND travels.date = @date;
";

			command.CommandText = query;

			foreach (int busId in vehicleIds)
			{
				command.Parameters.AddWithValue("@id", busId);
				command.Parameters.AddWithValue("@from", fromComboBox.Text);
				command.Parameters.AddWithValue("@to", toComboBox.Text);
				command.Parameters.AddWithValue("@date", dateSelected);
				SQLiteDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						// Örneğin: kullanıcı verilerini alabilirsiniz
						int id = reader.GetInt32(reader.GetOrdinal("id"));
						double price = reader.GetDouble(reader.GetOrdinal("price"));
						string company = reader.GetString(reader.GetOrdinal("company"));
						string from = reader.GetString(reader.GetOrdinal("from"));
						string time = reader.GetString(reader.GetOrdinal("time"));
						string date = reader.GetString(reader.GetOrdinal("date"));
						string to = reader.GetString(reader.GetOrdinal("to"));
						string type = reader.GetString(reader.GetOrdinal("type"));
						string brand = reader.GetString(reader.GetOrdinal("brand"));

						Vehicle vehicle = new Bus(brand, type);

						Travel travel = new Travel(
								id,
								from,
								to,
								company,
								price,
								date,
								time,
								vehicle
							);

						travels.Add(travel);

						Console.WriteLine(travel);
					}
				}
				reader.Close();
			};
			#endregion

			foreach (Travel travel in travels)
			{
				// DataGridView'e yeni bir satır ekle
				travelsGrid.Rows.Add(
					travel.From,
					travel.To,
					travel.Date,
					travel.Time,
					travel.Company,
					travel.Price.ToString(),
					travel.Vehicle.Type,
					travel.Vehicle.Brand
				);
			}
			travelsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			travelsGrid.MultiSelect = false; // Çoklu seçim istemiyorsanız
			travelsGrid.ClearSelection();

			travelsGrid.Visible = true;
			connection.Close();
		}

		private void TravelsGridOnCellContentSelect(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex < 0) return;

			selectedRow = rowIndex;
			deleteTravelButton.Visible = true;
		}

		private void DeleteTravelButtonOnClick(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(
		"Bu seyahati silmek istediğinizden emin misiniz?",
		"Seferi Sil",
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
					string query = "DELETE FROM travels WHERE id = @id";
					command.CommandText = query;
					command.Parameters.AddWithValue("@id", travels[selectedRow].Id);

					int rowsAffected = command.ExecuteNonQuery();

					if (rowsAffected > 0)
					{
						MessageBox.Show("Seyahat başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

						travelsGrid.Rows.RemoveAt(selectedRow);
					}
					else
					{
						MessageBox.Show("Silinecek kayıt bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				MessageBox.Show("Silme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void AddTravelButtonOnClick(object sender, EventArgs e)
		{
			if (addTravel == null || addTravel.IsDisposed)
			{
				addTravel = new AddTravel();
			}

			addTravel.ShowDialog();
		}
	}
}
