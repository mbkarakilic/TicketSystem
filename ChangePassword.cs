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
	public partial class ChangePassword : Form
	{
		private User user;
		public ChangePassword(User user)
		{
			InitializeComponent();
			this.user = user;
		}

		private void SubmitButtonOnClick(object sender, EventArgs e)
		{
			string oldPw = oldPasswordTextbox.Text;

			if (!oldPw.Equals(user.Password))
			{
				MessageBox.Show("Eski Parola Yanlış");
				return;
			}

			string newPw = newPasswordTextBox.Text;
			string newPwAgain = newPasswordAgainTextBox.Text;

			if (!newPwAgain.Equals(newPwAgain))
			{
				MessageBox.Show("Şifreler Aynı Olmalı");
				return;
			}

			try
			{
				DatabaseHelper db = DatabaseHelper.GetInstance();
				SQLiteConnection connection = db.GetConnection();
				SQLiteCommand command = db.GetCommand();

				connection.Open();

				// SQL sorgusu: Kullanıcının şifresini güncelle
				string query = "UPDATE users SET password = @newPassword WHERE id = @id";
				command.CommandText = query;
				command.Parameters.AddWithValue("@newPassword", newPw);  // Yeni şifreyi parametre olarak ekle
				command.Parameters.AddWithValue("@id", user.Id);  // Kullanıcı id'sini parametre olarak ekle

				int rowsAffected = command.ExecuteNonQuery();  // SQL sorgusunu çalıştır

				if (rowsAffected > 0)
				{
					MessageBox.Show("Şifre başarıyla değiştirildi.");

					user.Password = newPw;

					this.Close();  // Formu kapat
					this.Dispose();
				}
				else
				{
					MessageBox.Show("Bir hata oluştu. Şifre değiştirilemedi.");
				}

				connection.Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Hata: {ex.Message}");
			}
		}
	}
}
