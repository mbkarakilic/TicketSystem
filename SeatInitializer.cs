using System.Data.SQLite;
using TicketSystem.Models;

namespace TicketSystem
{
	public partial class SeatInitializer : Form
	{
		public string Type { get; set; }

		public int selectedSeat;
		private Button clicked;

		private List<Button> seats;

		private Dictionary<int, int> reservedSeats;

		public Travel Travel { get; set; }

		public SeatInitializer(Travel travel)
		{
			Travel = travel;
			Type = travel.Vehicle.Type;

			reservedSeats = new Dictionary<int, int>();


			selectedSeat = 0;
			clicked = null;

			seats = new List<Button>();

			InitializeComponent();
		}

		private void BusSeatOnLoad(object sender, EventArgs e)
		{
			GetReservedSeats(Travel.Id);

			Console.WriteLine(reservedSeats.Count);
			Console.WriteLine(Travel.Id);
			foreach (int seat in reservedSeats.Keys)
			{
				Console.WriteLine(seat);
			}

			InitSeats(10);
		}

		private void GetReservedSeats(int travelId)
		{
			try
			{
				DatabaseHelper db = DatabaseHelper.GetInstance();
				SQLiteConnection connection = db.GetConnection();
				SQLiteCommand command = db.GetCommand();

				connection.Open();

				string query = "SELECT seat_number, owner_gender FROM tickets WHERE travel_id = @travel_id";
				command.CommandText = query;
				command.Parameters.Clear();
				command.Parameters.AddWithValue("@travel_id", travelId);

				SQLiteDataReader reader = command.ExecuteReader();

				if (reader.HasRows)
				{
					while (reader.Read())
					{
						int seat_number = reader.GetInt32(reader.GetOrdinal("seat_number"));
						int owner_gender = reader.GetInt32(reader.GetOrdinal("owner_gender"));

						reservedSeats.Add(seat_number, owner_gender);
					}
				}
				reader.Close();
				connection.Close();
			}
			catch (Exception e)
			{
				Console.WriteLine($"Hata: {e.Message}");
				return;
			}
		}


		private void InitSeats(int amount)
		{
			// Koltukları temizle
			foreach (Control ctrl in this.Controls.OfType<Button>().ToList())
			{
				if (ctrl is Button btn && btn.Text != "Satın Al")
				{
					this.Controls.Remove(ctrl);
				}
			}

			// Yeni koltuk oluşturma
			int numOfSeat = 1;
			Console.WriteLine(Type);
			for (int i = 0; i < amount; i++)
			{
				for (int j = 0; j < 7; j++)
				{
					if (
							(Type.Equals("1+1") && (j == 1 || j == 2 || j == 3 || j == 5 || j == 6)) ||
							(Type.Equals("2+1") && (j == 2 || j == 3 || j == 5 || j == 6)) ||
							(Type.Equals("2+2") && (j == 2 || j == 5 || j == 6)) ||
							(Type.Equals("3+3") && (j == 3))
						)
					{
						continue;
					}

					Button seat = new Button
					{
						Height = 40,
						Width = 40,
						Top = 30 + (j * 45),
						Left = 30 + (i * 45),
						Text = numOfSeat.ToString()
					};

					seat.MouseDown += SeatButtonOnClick;
					seat.BackColor = Color.White;
					seat.ForeColor = Color.Black;

					foreach (int key in reservedSeats.Keys)
					{
						if (key == numOfSeat)
						{
							int value;
							reservedSeats.TryGetValue(key, out value);

							seat.BackColor = value == 0 ? Color.LightBlue : Color.Pink;
							seat.ForeColor = Color.White;
							seat.Enabled = false;
						}
					}

					seats.Add(seat);

					this.Controls.Add(seat);

					numOfSeat++;
				}
			}
		}

		private void SeatButtonOnClick(object? sender, EventArgs e)
		{
			if (sender == null) return;

			if (sender is Button)
			{
				if (clicked != null)
				{
					clicked.BackColor = Color.White;
					clicked.ForeColor = Color.Black;
				}

				clicked = (Button)sender;

				selectedSeat = int.Parse(clicked.Text);

				Console.WriteLine(selectedSeat);

				clicked.BackColor = Color.Green;
				clicked.ForeColor = Color.White;
			}
		}
	}
}
