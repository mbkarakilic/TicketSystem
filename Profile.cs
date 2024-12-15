using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketSystem.Models;

namespace TicketSystem
{
	public partial class Profile : Form
	{
		private User User;
		private ChangePassword changePassword;
		public Profile(User user)
		{
			this.User = user;
			InitializeComponent();

			nameLabel.Text = user.Name;
			surnameLabel.Text = user.Surname;
			phoneNumberLabel.Text = user.PhoneNumber;
			mailAddressLabel.Text = user.Email;
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void ChangePasswordButtonOnClick(object sender, EventArgs e)
		{
			if (changePassword == null || changePassword.IsDisposed)
			{
				changePassword = new ChangePassword(User);
			}

			changePassword.ShowDialog();
		}
	}
}
