using System.Data.SQLite;
//using System.IO;

namespace TicketSystem
{
	public class DatabaseHelper
	{
		private static string connectionString = @"Data Source= C:\Users\muzob\OneDrive\Desktop\TicketSystem\db\ticketSystem.db;Version=3;";

		private static DatabaseHelper? Instance;

		private SQLiteConnection connection;
		private SQLiteCommand command;

		private DatabaseHelper()
		{
			connection = new SQLiteConnection(connectionString);
			command = new SQLiteCommand(connection);
		}

		public SQLiteConnection GetConnection()
		{
			return connection;
		}

		public SQLiteCommand GetCommand()
		{
			return command;
		}


		public static DatabaseHelper GetInstance()
		{
			if (Instance == null)
			{
				Instance = new DatabaseHelper();
			}
			return Instance;
		}
	}
}
