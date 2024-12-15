namespace TicketSystem
{
	partial class Profile
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
			label1 = new Label();
			nameLabel = new Label();
			surnameLabel = new Label();
			label4 = new Label();
			phoneNumberLabel = new Label();
			label6 = new Label();
			mailAddressLabel = new Label();
			label8 = new Label();
			changePasswordButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.Location = new Point(80, 39);
			label1.Name = "label1";
			label1.Size = new Size(33, 15);
			label1.TabIndex = 0;
			label1.Text = "İsim:";
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new Point(119, 39);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(38, 15);
			nameLabel.TabIndex = 1;
			nameLabel.Text = "label2";
			// 
			// surnameLabel
			// 
			surnameLabel.AutoSize = true;
			surnameLabel.Location = new Point(138, 64);
			surnameLabel.Name = "surnameLabel";
			surnameLabel.Size = new Size(38, 15);
			surnameLabel.TabIndex = 3;
			surnameLabel.Text = "label3";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label4.Location = new Point(80, 64);
			label4.Name = "label4";
			label4.Size = new Size(52, 15);
			label4.TabIndex = 2;
			label4.Text = "Soyisim:";
			// 
			// phoneNumberLabel
			// 
			phoneNumberLabel.AutoSize = true;
			phoneNumberLabel.Location = new Point(190, 89);
			phoneNumberLabel.Name = "phoneNumberLabel";
			phoneNumberLabel.Size = new Size(38, 15);
			phoneNumberLabel.TabIndex = 5;
			phoneNumberLabel.Text = "label5";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label6.Location = new Point(80, 89);
			label6.Name = "label6";
			label6.Size = new Size(104, 15);
			label6.TabIndex = 4;
			label6.Text = "Telefon Numarası";
			// 
			// mailAddressLabel
			// 
			mailAddressLabel.AutoSize = true;
			mailAddressLabel.Location = new Point(157, 113);
			mailAddressLabel.Name = "mailAddressLabel";
			mailAddressLabel.Size = new Size(56, 15);
			mailAddressLabel.TabIndex = 7;
			mailAddressLabel.Text = "dsfsafasü";
			mailAddressLabel.TextAlign = ContentAlignment.TopRight;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label8.Location = new Point(80, 113);
			label8.Name = "label8";
			label8.Size = new Size(71, 15);
			label8.TabIndex = 6;
			label8.Text = "Mail Adresi:";
			label8.TextAlign = ContentAlignment.TopRight;
			// 
			// changePasswordButton
			// 
			changePasswordButton.Location = new Point(80, 203);
			changePasswordButton.Name = "changePasswordButton";
			changePasswordButton.Size = new Size(133, 23);
			changePasswordButton.TabIndex = 8;
			changePasswordButton.Text = "Şifremi Değiştir";
			changePasswordButton.UseVisualStyleBackColor = true;
			changePasswordButton.Click += ChangePasswordButtonOnClick;
			// 
			// Profile
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(678, 387);
			Controls.Add(changePasswordButton);
			Controls.Add(mailAddressLabel);
			Controls.Add(label8);
			Controls.Add(phoneNumberLabel);
			Controls.Add(label6);
			Controls.Add(surnameLabel);
			Controls.Add(label4);
			Controls.Add(nameLabel);
			Controls.Add(label1);
			Name = "Profile";
			Text = "Profile";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label nameLabel;
		private Label surnameLabel;
		private Label label4;
		private Label phoneNumberLabel;
		private Label label6;
		private Label mailAddressLabel;
		private Label label8;
		private Button changePasswordButton;
	}
}