using MindFusion.Charting;
using MindFusion.Charting.WinForms;
using System.Data.SQLite;
using TicketSystem.Models;

namespace TicketSystem
{
	public partial class Home : Form
	{
		private List<Travel> buses, airplanes, trains;
		private SimpleSeries busSeries, airplaneSeries, trainSeries;
		private List<string> busOrder, airplaneOrder, trainOrder;
		private List<double> busInfo, airplaneInfo, trainInfo;

		private int chartIndex;
		public Home()
		{
			chartIndex = 0;
			InitializeComponent();

			buses = FetchData(0);
			airplanes = FetchData(1);
			trains = FetchData(2);

			foreach (Travel travel in buses)
			{
				Console.WriteLine(travel.From + "-" + travel.To + ":" + travel.Price);
			}
			foreach (Travel travel in airplanes)
			{
				Console.WriteLine(travel.From + "-" + travel.To + ":" + travel.Price);
			}
			foreach (Travel travel in trains)
			{
				Console.WriteLine(travel.From + "-" + travel.To + ":" + travel.Price);
			}

			dataChart.ShowLegend = false;
			dataChart.ShowXCoordinates = false;

			dataChart.YAxis.Interval = 20;
			dataChart.YAxis.Title = "Fiyat";

			dataChart.XAxis.Interval = 10;
			dataChart.XAxis.MaxValue = 5;
			dataChart.XAxis.MinValue = -1;
			dataChart.XAxis.Title = "";

			busOrder = [];
			busInfo = new List<double>();
			for (int i = 0; i < 5; i++)
			{
				Travel travel = buses[i];
				busOrder.Add(travel.From + "-" + travel.To + ":" + travel.Price);
				busInfo.Add(travel.Price);
			}
			busSeries = new SimpleSeries(busInfo, busOrder);

			airplaneOrder = [];
			airplaneInfo = new List<double>();
			for (int i = 0; i < 5; i++)
			{
				Travel travel = airplanes[i];
				airplaneOrder.Add(travel.From + "-" + travel.To + ":" + travel.Price);
				airplaneInfo.Add(travel.Price);
			}
			airplaneSeries = new SimpleSeries(airplaneInfo, airplaneOrder);

			trainOrder = [];
			trainInfo = new List<double>();
			for (int i = 0; i < 5; i++)
			{
				Travel travel = trains[i];
				trainOrder.Add(travel.From + "-" + travel.To + ":" + travel.Price);
				trainInfo.Add(travel.Price);
			}
			trainSeries = new SimpleSeries(trainInfo, trainOrder);

			AdjustChart(0);
		}

		private List<Travel> FetchData(int classNo)
		{
			List<Travel> travels = new List<Travel>();
			//string today = DateTime.Now.ToString("yyyy-MM-dd");
			string today = "2024-12-16";//DateTime.Now.ToString("yyyy-MM-dd");

			List<int> ids = new List<int>();

			DatabaseHelper db = DatabaseHelper.GetInstance();

			SQLiteConnection connection = db.GetConnection();
			SQLiteCommand command = db.GetCommand();

			connection.Open();
			#region Buses
			string q1 = "SELECT Id FROM vehicles WHERE class = @classNo";
			command.CommandText = q1;
			command.Parameters.AddWithValue("@classNo", classNo);

			SQLiteDataReader reader1 = command.ExecuteReader();

			if (reader1.HasRows)
			{
				while (reader1.Read())
				{
					int id = reader1.GetInt32(reader1.GetOrdinal("Id"));

					ids.Add(id);
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
		AND travels.date = @date;
";

			command.CommandText = query;

			foreach (int id in ids)
			{
				command.Parameters.AddWithValue("@id", id);
				command.Parameters.AddWithValue("@date", today);
				SQLiteDataReader reader = command.ExecuteReader();
				if (reader.HasRows)
				{
					while (reader.Read())
					{
						// Örneğin: kullanıcı verilerini alabilirsiniz
						int idDB = reader.GetInt32(reader.GetOrdinal("id"));
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
								idDB,
								from,
								to,
								company,
								price,
								date,
								time,
								vehicle
							);

						travels.Add(travel);

					}
				}
				reader.Close();
			};
			connection.Close();
			#endregion

			travels = travels.OrderBy(t => t.Price).ToList();
			return travels;
		}

		private void ChartChangeButtonOnClick(object sender, EventArgs e)
		{
			chartIndex++;
			if (chartIndex == 3) chartIndex = 0;
			Console.WriteLine(chartIndex);
			AdjustChart(chartIndex);
		}

		private void AdjustChart(int chartIndex)
		{
			string[] titles = { "Otobüsler", "Uçaklar", "Trenler" };
			string[] buttonNames = { "Uçaklar", "Trenler", "Otobüsler" };
			SimpleSeries[] series = { busSeries, airplaneSeries, trainSeries };
			List<double>[] infos = { busInfo, airplaneInfo, trainInfo };
			chartChangeButton.Text = buttonNames[chartIndex];
			dataChart.Series.Clear();
			dataChart.Series.Add(series[chartIndex]);

			dataChart.Title = titles[chartIndex];
			dataChart.YAxis.MaxValue = infos[chartIndex][4] + 100;
			dataChart.YAxis.MinValue = infos[chartIndex][0] - 100;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
