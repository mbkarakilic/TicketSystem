using TicketSystem.Models.Observers.Login;
using TicketSystem.Models;

namespace TicketSystem
{
	public partial class Main : Form, ILoginObserver
	{
		private Home home;
		private Login login;
		private Buses buses;
		private Airplanes airplanes;
		private Trains trains;
		private AdminPanel adminPanel;

		private User user = null;
		public Main()
		{
			InitializeComponent();

			home = new Home();
			login = new Login();
			buses = new Buses();
			airplanes = new Airplanes();
			trains = new Trains();

			login.AddLoginObservers(this);


			SidePanel.Height = homeButton.Height;
			SidePanel.Top = homeButton.Top;
			homeButton.BringToFront();
			ShowFormInPanel(home);

			if (user == null || !user.IsAdmin)
			{
				adminPanelButton.Visible = false;
			}
		}

		private void ShowFormInPanel(Form form)
		{
			// Panel'i temizle
			mainPanel.Controls.Clear();

			// Form'un özelliklerini ayarla
			form.TopLevel = false; // Form'u ana formun bir parçası yap
			form.FormBorderStyle = FormBorderStyle.None; // Kenarlık kaldır
			form.Dock = DockStyle.Fill; // Panel'i tamamen kaplasın

			// Form'u panel içine ekle ve göster
			mainPanel.Controls.Add(form);
			form.Show();
		}

		private void LoginButtonOnClick(object sender, EventArgs e)
		{
			loginButton.BringToFront();
			login.ShowDialog();
		}

		private void BusBtnOnClick(object sender, EventArgs e)
		{
			SidePanel.Height = busBtn.Height;
			SidePanel.Top = busBtn.Top;
			busBtn.BringToFront();
			ShowFormInPanel(buses);
		}
		private void AirplaneBtnOnClick(object sender, EventArgs e)
		{
			SidePanel.Height = airplaneBtn.Height;
			SidePanel.Top = airplaneBtn.Top;
			airplaneBtn.BringToFront();
			ShowFormInPanel(airplanes);
		}
		private void TrainButtonOnClick(object sender, EventArgs e)
		{

			SidePanel.Height = trainButton.Height;
			SidePanel.Top = trainButton.Top;
			trainButton.BringToFront();
			ShowFormInPanel(trains);
		}

		public void OnLoginNotify(User user)
		{
			this.ShowLoginInfo(user);
		}

		private void ShowLoginInfo(User user)
		{
			this.user = user;

			if (user == null)
			{
				return;
			}

			if (user.IsAdmin)
			{
				adminPanelButton.Visible = true;
				adminPanel = new AdminPanel();
			}

			login.Close();

			loginButton.Visible = false;
			loginButton.Enabled = false;

			profileButton.Visible = true;
			profileButton.Enabled = true;

			nameLabel.Text = user.Name + "\n" + user.Surname;

			nameLabel.Visible = true;
		}

		private void AdminPanelButtonOnClick(object sender, EventArgs e)
		{
			if (!user.IsAdmin) return;

			SidePanel.Height = adminPanelButton.Height;
			SidePanel.Top = adminPanelButton.Top;
			adminPanelButton.BringToFront();
			ShowFormInPanel(adminPanel);
		}

		private void HomeButtonOnClick(object sender, EventArgs e)
		{
			SidePanel.Height = homeButton.Height;
			SidePanel.Top = homeButton.Top;
			homeButton.BringToFront();
			ShowFormInPanel(home);

		}
	}
}
