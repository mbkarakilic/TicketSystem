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
	public partial class AddTravel : Form
	{
		private string[] busCompanies = ["Pamukkale", "Ulusoy", "Metro", "Varan", "Kamil Koç"];
		private string[] airplaneCompanies = ["Türk Hava Yolları", "Pegasus", "Anadolu Jet"];
		private string[] trainCompanies = ["TCDD"];

		private int typeSelectedIndex;
		private Vehicle selectedVehicle;
		private string from, to, date, time, company;
		private int price;

		private List<Vehicle> vehicles;
		public AddTravel()
		{
			selectedVehicle = null;

			vehicles = new List<Vehicle>();
			typeSelectedIndex = -1;
			InitializeComponent();
		}

		private void SubmitButtonOnClick(object sender, EventArgs e)
		{
			if (selectedVehicle == null)
			{
				errorText.Visible = true;
				sameCityErrorText.Visible = false;
				return;
			};
			if (from == null || from.Equals(""))
			{
				errorText.Visible = true;
				sameCityErrorText.Visible = false;
				return;
			};
			if (to == null || to.Equals(""))
			{
				errorText.Visible = true;
				sameCityErrorText.Visible = false;
				return;
			};
			if (from.Equals(to))
			{
				errorText.Visible = false;
				sameCityErrorText.Visible = true;
				return;
			}
			if (time == null || time.Equals(""))
			{
				errorText.Visible = true;
				sameCityErrorText.Visible = false;
				return;
			};
			if (date == null || date.Equals(""))
			{
				errorText.Visible = true;
				sameCityErrorText.Visible = false;
				return;
			};
			if (company == null || company.Equals(""))
			{
				errorText.Visible = true;
				sameCityErrorText.Visible = false;
				return;
			};
			if (price == 0 || priceTextBox.Text.Equals(""))
			{
				errorText.Visible = true;
				sameCityErrorText.Visible = false;
				return;
			};

			sameCityErrorText.Visible = false;
			errorText.Visible = false;

			DatabaseHelper db = DatabaseHelper.GetInstance();

			SQLiteConnection connection = db.GetConnection();
			SQLiteCommand command = db.GetCommand();

			connection.Open();

			string q = "INSERT INTO travels ([from], [to], date, time, company, price, vehicle_id) VALUES (@from, @to, @date, @time, @company, @price, @vehicleId)";
			command.CommandText = q;
			command.Parameters.AddWithValue("@from", from);
			command.Parameters.AddWithValue("@to", to);
			command.Parameters.AddWithValue("@date", date);
			command.Parameters.AddWithValue("@time", time);
			command.Parameters.AddWithValue("@company", company);
			command.Parameters.AddWithValue("@price", price);
			command.Parameters.AddWithValue("@vehicleId", selectedVehicle.Id);

			try
			{
				int rows = command.ExecuteNonQuery();

				if (rows > 0)
				{
					MessageBox.Show("Sefer başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hata", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			connection.Close();
			Close();
			Dispose();
		}

		private void TypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			vehicleComboBox.Enabled = false;
			companyComboBox.Enabled = false;

			vehicleComboBox.SelectedIndex = -1;
			vehicleComboBox.Text = "";

			companyComboBox.SelectedIndex = -1;
			companyComboBox.Text = "";

			typeSelectedIndex = typeComboBox.SelectedIndex;

			DatabaseHelper db = DatabaseHelper.GetInstance();

			SQLiteConnection connection = db.GetConnection();
			SQLiteCommand command = db.GetCommand();

			connection.Open();

			string q1 = "SELECT * FROM vehicles WHERE class = @type";
			command.CommandText = q1;
			command.Parameters.AddWithValue("@type", typeSelectedIndex);

			SQLiteDataReader reader1 = command.ExecuteReader();


			vehicles.Clear();
			if (reader1.HasRows)
			{
				while (reader1.Read())
				{
					int id = reader1.GetInt32(reader1.GetOrdinal("id"));
					string brand = reader1.GetString(reader1.GetOrdinal("brand"));
					string type = reader1.GetString(reader1.GetOrdinal("type"));

					Vehicle vehicle;
					if (typeSelectedIndex == 0)
					{
						vehicle = new Bus(brand, type);
					}
					else if (typeSelectedIndex == 1)
					{
						vehicle = new Airplane(brand, type);
					}
					else
					{
						vehicle = new Train(brand, type);
					}

					vehicle.Id = id;
					vehicles.Add(vehicle);

				}
			}
			reader1.Close();
			connection.Close();

			vehicleComboBox.Items.Clear();

			Console.WriteLine(vehicles.Count);

			foreach (Vehicle vehicle in vehicles)
			{
				vehicleComboBox.Items.Add(vehicle.Brand + "(" + vehicle.Type + ")");
			}

			string[] companies = null;
			if (typeSelectedIndex == 0)
			{
				companies = busCompanies;
			}
			else if (typeSelectedIndex == 1)
			{
				companies = airplaneCompanies;
			}
			else
			{
				companies = trainCompanies;
			}

			companyComboBox.Items.Clear();
			foreach (string company in companies)
			{
				companyComboBox.Items.Add(company);
			}

			vehicleComboBox.Enabled = true;
			companyComboBox.Enabled = true;
		}

		private void VehicleComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
		{
			if (vehicleComboBox.SelectedIndex == -1) selectedVehicle = null;
			else selectedVehicle = vehicles[vehicleComboBox.SelectedIndex];
		}

		private void FromComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
		{
			from = fromComboBox.Text;
		}

		private void ToComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
		{
			to = toComboBox.Text;
		}

		private void PriceTextBoxOmTextChanged(object sender, EventArgs e)
		{
			price = int.Parse(priceTextBox.Text);

		}

		private void DateTimePickerOnValueChanged(object sender, EventArgs e)
		{
			string[] dateParts = dateTimePicker.Text.Split('.'); // "." ile böl
			Array.Reverse(dateParts); // Diziyi ters çevir
			date = string.Join("-", dateParts);
		}

		private void CompanyComboBoxOnSelectedIndexChanged(object sender, EventArgs e)
		{
			if (companyComboBox.SelectedIndex == -1) company = "";
			else company = companyComboBox.Text;
		}

		private void timeTextBox_TextChanged(object sender, EventArgs e)
		{
			time = timeTextBox.Text;
		}
	}
}
