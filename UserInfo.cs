using TicketSystem.Models;

namespace TicketSystem
{
	public partial class UserInfo : Form
	{
		public Travel Travel { get; set; }
		public int seatNo;
		public UserInfo(Travel travel, int seatNo)
		{
			this.Travel = travel;
			this.seatNo = seatNo;


			if (Travel == null)
			{
				MessageBox.Show("Lütfen bir seyehat seçiniz");
				Close();
				return;
			}

			InitializeComponent();

			fromText.Text = Travel.From;
			toText.Text = Travel.To;
			companyText.Text = Travel.Company;
			priceText.Text = "₺" + Travel.Price;
			dateText.Text = Travel.Date;
			timeText.Text = Travel.Time;

			seatText.Text = seatNo.ToString();
		}

		public void UpdateInfos()
		{
			seatText.Text = seatNo.ToString();
		}

		public TicketOwner GetTicketOwner()
		{
			string name = nameTextbox.Text;
			string surname = surnameTextbox.Text;
			string phoneNumber = phoneNumberTextbox.Text;
			string mail = mailTextbox.Text;
			int gender = genderCombobox.SelectedIndex;

			TicketOwner ticketOwner = new TicketOwner(name, surname, phoneNumber, mail, gender, seatNo);

			return ticketOwner;
		}

		public bool CheckInputs()
		{
			bool result = nameTextbox.Text.Equals("") || surnameTextbox.Text.Equals("") || phoneNumberTextbox.Text.Equals("") || mailTextbox.Text.Equals("") || genderCombobox.Text.Equals("Cinsiyet");

			errorText.Visible = result;

			return !result;
		}
	}
}
