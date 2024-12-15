namespace TicketSystem
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			loginButton = new Button();
			busBtn = new Button();
			mainPanel = new Panel();
			nameLabel = new Label();
			adminPanelButton = new Button();
			SidePanel = new Panel();
			airplaneBtn = new Button();
			panel1 = new Panel();
			trainButton = new Button();
			profileButton = new Button();
			homeButton = new Button();
			SuspendLayout();
			// 
			// loginButton
			// 
			loginButton.Image = (Image)resources.GetObject("loginButton.Image");
			loginButton.ImageAlign = ContentAlignment.MiddleLeft;
			loginButton.Location = new Point(8, 190);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(84, 23);
			loginButton.TabIndex = 0;
			loginButton.Text = "Giriş Yap";
			loginButton.TextAlign = ContentAlignment.MiddleRight;
			loginButton.UseVisualStyleBackColor = true;
			loginButton.Click += LoginButtonOnClick;
			// 
			// busBtn
			// 
			busBtn.Image = (Image)resources.GetObject("busBtn.Image");
			busBtn.ImageAlign = ContentAlignment.MiddleLeft;
			busBtn.Location = new Point(8, 44);
			busBtn.Name = "busBtn";
			busBtn.Size = new Size(84, 23);
			busBtn.TabIndex = 1;
			busBtn.Text = "Otobüs";
			busBtn.TextAlign = ContentAlignment.MiddleRight;
			busBtn.UseVisualStyleBackColor = true;
			busBtn.Click += BusBtnOnClick;
			// 
			// mainPanel
			// 
			mainPanel.Location = new Point(93, 12);
			mainPanel.Name = "mainPanel";
			mainPanel.Size = new Size(694, 426);
			mainPanel.TabIndex = 2;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new Point(12, 355);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(38, 15);
			nameLabel.TabIndex = 3;
			nameLabel.Text = "label1";
			nameLabel.Visible = false;
			// 
			// adminPanelButton
			// 
			adminPanelButton.Image = (Image)resources.GetObject("adminPanelButton.Image");
			adminPanelButton.ImageAlign = ContentAlignment.MiddleLeft;
			adminPanelButton.Location = new Point(8, 415);
			adminPanelButton.Name = "adminPanelButton";
			adminPanelButton.Size = new Size(84, 23);
			adminPanelButton.TabIndex = 5;
			adminPanelButton.Text = "Admin";
			adminPanelButton.TextAlign = ContentAlignment.MiddleRight;
			adminPanelButton.UseVisualStyleBackColor = true;
			adminPanelButton.Click += AdminPanelButtonOnClick;
			// 
			// SidePanel
			// 
			SidePanel.BackColor = Color.FromArgb(250, 0, 58);
			SidePanel.Location = new Point(-4, 15);
			SidePanel.Name = "SidePanel";
			SidePanel.Size = new Size(10, 20);
			SidePanel.TabIndex = 0;
			// 
			// airplaneBtn
			// 
			airplaneBtn.Image = (Image)resources.GetObject("airplaneBtn.Image");
			airplaneBtn.ImageAlign = ContentAlignment.MiddleLeft;
			airplaneBtn.Location = new Point(8, 79);
			airplaneBtn.Name = "airplaneBtn";
			airplaneBtn.Size = new Size(84, 23);
			airplaneBtn.TabIndex = 6;
			airplaneBtn.Text = "Uçak";
			airplaneBtn.TextAlign = ContentAlignment.MiddleRight;
			airplaneBtn.UseVisualStyleBackColor = true;
			airplaneBtn.Click += AirplaneBtnOnClick;
			// 
			// panel1
			// 
			panel1.BackColor = Color.Red;
			panel1.Location = new Point(93, 10);
			panel1.Name = "panel1";
			panel1.Size = new Size(3, 430);
			panel1.TabIndex = 0;
			// 
			// trainButton
			// 
			trainButton.Image = (Image)resources.GetObject("trainButton.Image");
			trainButton.ImageAlign = ContentAlignment.MiddleLeft;
			trainButton.Location = new Point(8, 114);
			trainButton.Name = "trainButton";
			trainButton.Size = new Size(84, 23);
			trainButton.TabIndex = 7;
			trainButton.Text = "Tren";
			trainButton.TextAlign = ContentAlignment.MiddleRight;
			trainButton.UseVisualStyleBackColor = true;
			trainButton.Click += TrainButtonOnClick;
			// 
			// profileButton
			// 
			profileButton.Image = (Image)resources.GetObject("profileButton.Image");
			profileButton.ImageAlign = ContentAlignment.MiddleLeft;
			profileButton.Location = new Point(8, 190);
			profileButton.Name = "profileButton";
			profileButton.Size = new Size(84, 23);
			profileButton.TabIndex = 8;
			profileButton.Text = "Profil";
			profileButton.TextAlign = ContentAlignment.MiddleRight;
			profileButton.UseVisualStyleBackColor = true;
			profileButton.Visible = false;
			// 
			// homeButton
			// 
			homeButton.Image = (Image)resources.GetObject("homeButton.Image");
			homeButton.ImageAlign = ContentAlignment.MiddleLeft;
			homeButton.Location = new Point(8, 13);
			homeButton.Name = "homeButton";
			homeButton.Size = new Size(84, 23);
			homeButton.TabIndex = 9;
			homeButton.Text = "Ana Sayfa";
			homeButton.TextAlign = ContentAlignment.MiddleRight;
			homeButton.UseVisualStyleBackColor = true;
			homeButton.Click += HomeButtonOnClick;
			// 
			// Main
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(homeButton);
			Controls.Add(profileButton);
			Controls.Add(trainButton);
			Controls.Add(panel1);
			Controls.Add(airplaneBtn);
			Controls.Add(SidePanel);
			Controls.Add(adminPanelButton);
			Controls.Add(nameLabel);
			Controls.Add(mainPanel);
			Controls.Add(busBtn);
			Controls.Add(loginButton);
			Name = "Main";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ŞuBilet";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button loginButton;
		private Button busBtn;
		private Panel mainPanel;
		private Label nameLabel;
		private Button adminPanelButton;
		private Panel SidePanel;
		private Button airplaneBtn;
		private Panel panel1;
		private Button trainButton;
		private Button profileButton;
		private Button homeButton;
	}
}