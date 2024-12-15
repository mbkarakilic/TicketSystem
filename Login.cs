using System.Data.SQLite;
using TicketSystem.Models.Observers.Login;
using TicketSystem.Models;

namespace TicketSystem
{
	public partial class Login : Form, ILoginSubject
	{
		private List<ILoginObserver> observers;
		public Login()
		{
			InitializeComponent();

			observers = new List<ILoginObserver>();
		}

		public void AddLoginObservers(ILoginObserver observer)
		{
			observers.Add(observer);
		}

		public void NotifyLoginObservers(User user)
		{
			foreach (ILoginObserver observer in observers)
			{
				if (observer != null)
				{
					observer.OnLoginNotify(user);
				}
			}
		}

		public void RemoveLoginObservers(ILoginObserver observer)
		{
			observers.Remove(observer);
		}

		private void loginBtnOnClick(object sender, EventArgs e)
		{
			string mail = mailTxt.Text;
			string password = passwordTxt.Text;

			DatabaseHelper db = DatabaseHelper.GetInstance();

			SQLiteConnection connection = db.GetConnection();
			SQLiteCommand command = db.GetCommand();

			connection.Open();

			string query = "SELECT * FROM users WHERE mail = @mail AND password = @password";
			command.CommandText = query;

			// SQL injection'ı önlemek için parametre ekliyoruz
			command.Parameters.AddWithValue("@mail", mail);
			command.Parameters.AddWithValue("@password", password);

			SQLiteDataReader reader = command.ExecuteReader();

			User user = null;
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					// Örneğin: kullanıcı verilerini alabilirsiniz
					int id = reader.GetInt32(reader.GetOrdinal("id"));
					string name = reader.GetString(reader.GetOrdinal("name"));
					string surname = reader.GetString(reader.GetOrdinal("surname"));
					string email = reader.GetString(reader.GetOrdinal("mail"));
					int isAdminInt = reader.GetInt32(reader.GetOrdinal("isAdmin"));
					bool isAdmin = isAdminInt == 1;

					Console.WriteLine($"ID: {id}, Name: {name}, Surname: {surname}, Email: {email}");

					user = new User(id, name, surname, email, isAdmin);
				}

				loginFormPanel.Visible = false; // Giriş başarılı
				NotifyLoginObservers(user);
			}
			else
			{
				Console.WriteLine("Kullanıcı Yok");
			}

			reader.Close();
			connection.Close();
		}

	}
}
