using System.Data.SQLite;
using TicketSystem.Models;
using TicketSystem.States.Buy;

namespace TicketSystem
{
	public partial class TravelBuySection : Form
	{
		private SeatInitializer seatInitializer;
		private UserInfo userInfo;
		private Payment payment;

		private Travel Travel;
		private int seatInfo = 0;

		private BuyState buyState;
		public TravelBuySection(Travel travel)
		{
			Travel = travel;

			InitializeComponent();

			userInfo = null;
			payment = null;
			seatInitializer = new SeatInitializer(Travel);

			buyState = BuyState.SeatSelect;
			ChangeSubmitButtonText();
			ChangeBackButtonText();
			ShowFormInPanel(seatInitializer);
		}

		private void ChangeSubmitButtonText()
		{
			switch (buyState)
			{
				case BuyState.SeatSelect:
					{
						submitButton.Text = "Seç";
						break;
					}
				case BuyState.UserInfo:
					{
						submitButton.Text = "Ödeme";
						break;
					}
				case BuyState.Payment:
					{
						submitButton.Text = "Onayla";
						break;
					}
			}
		}

		private void ChangeBackButtonText()
		{
			switch (buyState)
			{
				case BuyState.SeatSelect:
					{
						backButton.Text = "İptal";
						break;
					}
				case BuyState.UserInfo:
					{
						backButton.Text = "Geri";
						break;
					}
				case BuyState.Payment:
					{
						backButton.Text = "Geri";
						break;
					}
			}
		}

		private void ShowFormInPanel(Form form)
		{
			// Panel'i temizle
			panel.Controls.Clear();

			// Form'un özelliklerini ayarla
			form.TopLevel = false; // Form'u ana formun bir parçası yap
			form.FormBorderStyle = FormBorderStyle.None; // Kenarlık kaldır
			form.Dock = DockStyle.Fill; // Panel'i tamamen kaplasın

			// Form'u panel içine ekle ve göster
			panel.Controls.Add(form);
			form.Show();
		}

		private void SubmitButtonOnClick(object sender, EventArgs e)
		{
			switch (buyState)
			{
				case BuyState.SeatSelect:
					{
						seatInfo = seatInitializer.selectedSeat;
						if (userInfo == null)
						{
							userInfo = new UserInfo(Travel, seatInfo);
						}
						else
						{
							userInfo.seatNo = seatInfo;
							userInfo.UpdateInfos();
						}
						ShowFormInPanel(userInfo);
						buyState = BuyState.UserInfo;
						break;
					}
				case BuyState.UserInfo:
					{
						if (CanGoToPayment())
						{
							if (payment == null)
							{
								payment = new Payment();
							}

							ShowFormInPanel(payment);
							buyState = BuyState.Payment;
						}
						break;
					}

				case BuyState.Payment:
					{
						if (CanPaymentBeApproved())
						{
							TicketOwner ticketOwner = userInfo.GetTicketOwner();
							ApprovePayment();
							ShowFormInPanel(seatInitializer);
						}
						buyState = BuyState.SeatSelect;
						break;
					}

			}
			ChangeSubmitButtonText();
			ChangeBackButtonText();
		}

		private bool CanGoToPayment()
		{
			if (userInfo == null) { return false; }
			return userInfo.CheckInputs();
		}

		private bool CanPaymentBeApproved()
		{
			if (payment == null)
			{
				return false;
			}

			return payment.CheckInputs();
		}

		private void ApprovePayment()
		{
			try
			{
				// TicketOwner bilgilerini al
				TicketOwner ticketOwner = userInfo.GetTicketOwner();

				// SQLite bağlantısını al
				string pnr = "";
				using (SQLiteConnection connection = DatabaseHelper.GetInstance().GetConnection())
				{
					connection.Open();

					string[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray().Select(c => c.ToString()).ToArray();
					string[] numbers = "123456789".ToCharArray().Select(c => c.ToString()).ToArray();

					Random random = new Random();

					for (int i = 0; i < 6; i++)
					{
						bool isNumber = random.Next(2) == 1;

						if (isNumber)
						{
							string number = numbers[random.Next(numbers.Length)];
							pnr += number;
						}
						else
						{
							string letter = alphabet[random.Next(alphabet.Length)];
							pnr += letter;
						}
					}

					// INSERT komutunu hazırla
					string query = @"
                INSERT INTO tickets (owner_name, owner_surname, owner_phone_number, owner_mail, owner_gender, seat_number, travel_id, pnr)
                VALUES (@owner_name, @owner_surname, @owner_phone_number, @owner_mail, @owner_gender, @seat_number, @travel_id, @pnr)";

					using (SQLiteCommand command = new SQLiteCommand(query, connection))
					{
						// Parametreleri ekle
						command.Parameters.AddWithValue("@owner_name", ticketOwner.Name);
						command.Parameters.AddWithValue("@owner_surname", ticketOwner.Surname);
						command.Parameters.AddWithValue("@owner_phone_number", ticketOwner.PhoneNumber);
						command.Parameters.AddWithValue("@owner_mail", ticketOwner.Email);
						command.Parameters.AddWithValue("@owner_gender", ticketOwner.Gender);
						command.Parameters.AddWithValue("@seat_number", seatInfo); // seatInfo zaten seçilen koltuk numarasını tutuyor
						command.Parameters.AddWithValue("@travel_id", Travel.Id); // Travel objesindeki Id kullanılıyor
						command.Parameters.AddWithValue("@pnr", pnr); // Travel objesindeki Id kullanılıyor

						// Komutu çalıştır
						command.ExecuteNonQuery();
					}
				}

				MessageBox.Show($"Ödeme İşlemi Başarılı\nSeyehat bilgileriniz size SMS olarak iletilecektir.\n\nPNR Kodunuz:{pnr}");

				// Ekranı kapat veya işlem tamamlandıktan sonra başka bir işlem yap
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Bir hata oluştu: {ex.Message}");
			}
		}

		private void BackButtonOnClick(object sender, EventArgs e)
		{
			switch (buyState)
			{
				case BuyState.SeatSelect:
					{
						Close();
						break;
					}
				case BuyState.UserInfo:
					{
						ShowFormInPanel(seatInitializer);
						buyState = BuyState.SeatSelect;
						break;
					}

				case BuyState.Payment:
					{
						ShowFormInPanel(userInfo);
						buyState = BuyState.UserInfo;
						break;
					}

			}
			ChangeSubmitButtonText();
			ChangeBackButtonText();
		}
	}
}
