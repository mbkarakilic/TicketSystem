using System.Data.SQLite;
using TicketSystem.Models;

namespace TicketSystem
{
	public partial class Buses : Form
	{
		private List<Travel> travels;
		private List<int> busIds;

		private int selectedRow;
		public Buses()
		{
			selectedRow = 0;

			travels = [];
			busIds = [];

			InitializeComponent();

			submitButton.Visible = false;
		}

		private void SearchButtonOnClick(object sender, EventArgs e)
		{
			if (fromComboBox.Text.Equals("") || toComboBox.Equals(""))
			{
				errorText.Visible = true;
				return;
			}

			errorText.Visible = false;

			busGrid.Visible = false;
			busGrid.Rows.Clear();

			Console.WriteLine(dateTimePicker.Text);
			string[] dateParts = dateTimePicker.Text.Split('.'); // "." ile böl
			Array.Reverse(dateParts); // Diziyi ters çevir
			string dateSelected = string.Join("-", dateParts); // "-" ile birleştir

			travels.Clear();
			busIds.Clear();

			DatabaseHelper db = DatabaseHelper.GetInstance();

			SQLiteConnection connection = db.GetConnection();
			SQLiteCommand command = db.GetCommand();

			connection.Open();

			#region Buses
			string q1 = "SELECT Id FROM vehicles WHERE class = 0";
			command.CommandText = q1;

			SQLiteDataReader reader1 = command.ExecuteReader();

			if (reader1.HasRows)
			{
				while (reader1.Read())
				{
					int id = reader1.GetInt32(reader1.GetOrdinal("Id"));

					busIds.Add(id);
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

			foreach (int busId in busIds)
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
				busGrid.Rows.Add(
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
			busGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			busGrid.MultiSelect = false; // Çoklu seçim istemiyorsanız
			busGrid.ClearSelection();

			busGrid.Visible = true;
			connection.Close();
		}

		private void BusGridOnClickCellContent(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex < 0) return;

			selectedRow = rowIndex;
			submitButton.Visible = true;
		}

		private void SubmitButtonOnClick(object sender, EventArgs e)
		{
			Travel travel = travels[selectedRow];

			string type = travel.Vehicle.Type;

			TravelBuySection travelBuySection = new TravelBuySection(travel);
			travelBuySection.ShowDialog();
		}
	}
}
