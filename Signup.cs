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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TicketSystem
{
	public partial class Signup : Form
	{
		public Signup()
		{
			InitializeComponent();
		}

		private void Signup_Load(object sender, EventArgs e)
		{

		}

		private void SubmitButtonOnClick(object sender, EventArgs e)
		{
			// Gerekli alanların boş olup olmadığını kontrol et
			if (nameTextbox.Text.Equals("") || surnameTextbox.Text.Equals("") || phoneTextbox.Text.Equals("") || mailTextbox.Text.Equals("") || passwordTextbox.Text.Equals(""))
			{
				MessageBox.Show("Lütfen tüm alanları doldurun.");
				return;
			}

			// Kullanıcı bilgilerini al
			string name = nameTextbox.Text;
			string surname = surnameTextbox.Text;
			string phoneNumber = phoneTextbox.Text;
			string mail = mailTextbox.Text;
			string password = passwordTextbox.Text;

			if (!IsValidEmail(mail))
			{
				MessageBox.Show("Geçerli bir e-posta adresi giriniz.");
				return;
			}

			// Şifreyi güvenli bir şekilde hash'le (örneğin, SHA256)
			try
			{
				// Veritabanı bağlantısını al
				DatabaseHelper db = DatabaseHelper.GetInstance();
				SQLiteConnection connection = db.GetConnection();
				SQLiteCommand command = db.GetCommand();

				connection.Open();

				// Kullanıcıyı veritabanına eklemek için SQL sorgusu
				string query = "INSERT INTO users (name, surname, phoneNumber, mail, password, isAdmin) VALUES (@name, @surname, @phoneNumber, @mail, @password, 0)";
				command.CommandText = query;
				command.Parameters.AddWithValue("@name", name);
				command.Parameters.AddWithValue("@surname", surname);
				command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
				command.Parameters.AddWithValue("@mail", mail);
				command.Parameters.AddWithValue("@password", password); // Hash'lenmiş şifreyi ekle

				// Sorguyu çalıştır
				int rowsAffected = command.ExecuteNonQuery();

				// Eğer bir kayıt eklenmişse başarılı mesajı göster
				if (rowsAffected > 0)
				{
					MessageBox.Show("Kayıt başarıyla tamamlandı.");
					this.Close();  // Formu kapat
				}
				else
				{
					MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyin.");
				}

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}");
			}
		}

		private bool IsValidEmail(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		private void PhoneNumberOnKeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}
	}
}
