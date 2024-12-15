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
	public partial class Airplanes : Form
	{
		private List<Travel> travels;
		private List<int> airplaneIds;

		private int selectedRow;
		public Airplanes()
		{
			selectedRow = 0;

			travels = [];
			airplaneIds = [];

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

			airplaneGrid.Visible = false;
			airplaneGrid.Rows.Clear();

			Console.WriteLine(dateTimePicker.Text);
			string[] dateParts = dateTimePicker.Text.Split('.'); // "." ile böl
			Array.Reverse(dateParts); // Diziyi ters çevir
			string dateSelected = string.Join("-", dateParts); // "-" ile birleştir

			travels.Clear();
			airplaneIds.Clear();

			DatabaseHelper db = DatabaseHelper.GetInstance();

			SQLiteConnection connection = db.GetConnection();
			SQLiteCommand command = db.GetCommand();

			connection.Open();

			#region Airplanes 
			string q1 = "SELECT Id FROM vehicles WHERE class = 1";
			command.CommandText = q1;

			SQLiteDataReader reader1 = command.ExecuteReader();

			if (reader1.HasRows)
			{
				while (reader1.Read())
				{
					int id = reader1.GetInt32(reader1.GetOrdinal("Id"));

					airplaneIds.Add(id);
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

			foreach (int airplaneId in airplaneIds)
			{
				command.Parameters.AddWithValue("@id", airplaneId);
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
				airplaneGrid.Rows.Add(
					travel.From,
					travel.To,
					travel.Date,
					travel.Time,
					travel.Company,
					travel.Price.ToString()
				);
			}
			airplaneGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			airplaneGrid.MultiSelect = false; // Çoklu seçim istemiyorsanız
			airplaneGrid.ClearSelection();

			airplaneGrid.Visible = true;
			connection.Close();
		}

		private void SubmitButtonOnClick(object sender, EventArgs e)
		{
			Travel travel = travels[selectedRow];

			string type = travel.Vehicle.Type;

			TravelBuySection travelBuySection = new TravelBuySection(travel);
			travelBuySection.ShowDialog();
		}

		private void AirplaneGridOnCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowIndex = e.RowIndex;
			if (rowIndex < 0) return;

			selectedRow = rowIndex;
			submitButton.Visible = true;
		}
	}
}
