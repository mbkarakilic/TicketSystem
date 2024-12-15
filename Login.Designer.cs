namespace TicketSystem
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			mailTxt = new TextBox();
			loginFormPanel = new Panel();
			pictureBox2 = new PictureBox();
			pictureBox1 = new PictureBox();
			loginBtn = new Button();
			passwordTxt = new TextBox();
			loginFormPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// mailTxt
			// 
			mailTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			mailTxt.Location = new Point(40, 36);
			mailTxt.Margin = new Padding(10);
			mailTxt.Name = "mailTxt";
			mailTxt.PlaceholderText = "E-Posta";
			mailTxt.Size = new Size(171, 23);
			mailTxt.TabIndex = 0;
			// 
			// loginFormPanel
			// 
			loginFormPanel.Controls.Add(pictureBox2);
			loginFormPanel.Controls.Add(pictureBox1);
			loginFormPanel.Controls.Add(loginBtn);
			loginFormPanel.Controls.Add(passwordTxt);
			loginFormPanel.Controls.Add(mailTxt);
			loginFormPanel.Location = new Point(205, 49);
			loginFormPanel.Name = "loginFormPanel";
			loginFormPanel.Size = new Size(250, 250);
			loginFormPanel.TabIndex = 1;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(0, 114);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(30, 23);
			pictureBox2.TabIndex = 3;
			pictureBox2.TabStop = false;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(0, 36);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(34, 23);
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// loginBtn
			// 
			loginBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			loginBtn.Location = new Point(85, 195);
			loginBtn.Name = "loginBtn";
			loginBtn.Size = new Size(75, 23);
			loginBtn.TabIndex = 2;
			loginBtn.Text = "Giriş Yap";
			loginBtn.UseVisualStyleBackColor = true;
			loginBtn.Click += loginBtnOnClick;
			// 
			// passwordTxt
			// 
			passwordTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			passwordTxt.Location = new Point(40, 114);
			passwordTxt.Margin = new Padding(10);
			passwordTxt.Name = "passwordTxt";
			passwordTxt.PasswordChar = '*';
			passwordTxt.PlaceholderText = "Şifre";
			passwordTxt.Size = new Size(171, 23);
			passwordTxt.TabIndex = 1;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(678, 387);
			Controls.Add(loginFormPanel);
			Name = "Login";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Home";
			loginFormPanel.ResumeLayout(false);
			loginFormPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private TextBox mailTxt;
		private Panel loginFormPanel;
		private TextBox passwordTxt;
		private Button loginBtn;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
	}
}