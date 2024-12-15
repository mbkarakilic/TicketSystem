namespace TicketSystem
{
	public partial class Payment : Form
	{
		public Payment()
		{
			InitializeComponent();
		}

		public bool CheckInputs()
		{
			bool result = cardNumberText.Text.Equals("") || nameSurnameText.Text.Equals("") || expDateText.Text.Equals("") || cvvText.Text.Equals("");

			errorText.Visible = result;

			return !result;
		}
	}
}
