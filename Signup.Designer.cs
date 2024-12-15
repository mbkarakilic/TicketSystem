namespace TicketSystem
{
	partial class Signup
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
			submitButton = new Button();
			nameTextbox = new TextBox();
			surnameTextbox = new TextBox();
			label2 = new Label();
			phoneTextbox = new TextBox();
			label3 = new Label();
			mailTextbox = new TextBox();
			label4 = new Label();
			passwordTextbox = new TextBox();
			label5 = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(29, 32);
			label1.Name = "label1";
			label1.Size = new Size(29, 15);
			label1.TabIndex = 0;
			label1.Text = "İsim";
			// 
			// submitButton
			// 
			submitButton.Location = new Point(257, 358);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(75, 23);
			submitButton.TabIndex = 1;
			submitButton.Text = "Kayıt Ol";
			submitButton.UseVisualStyleBackColor = true;
			submitButton.Click += SubmitButtonOnClick;
			// 
			// nameTextbox
			// 
			nameTextbox.Location = new Point(29, 50);
			nameTextbox.Name = "nameTextbox";
			nameTextbox.Size = new Size(100, 23);
			nameTextbox.TabIndex = 2;
			// 
			// surnameTextbox
			// 
			surnameTextbox.Location = new Point(29, 112);
			surnameTextbox.Name = "surnameTextbox";
			surnameTextbox.Size = new Size(100, 23);
			surnameTextbox.TabIndex = 4;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(29, 94);
			label2.Name = "label2";
			label2.Size = new Size(48, 15);
			label2.TabIndex = 3;
			label2.Text = "Soyisim";
			// 
			// phoneTextbox
			// 
			phoneTextbox.Location = new Point(29, 175);
			phoneTextbox.Name = "phoneTextbox";
			phoneTextbox.Size = new Size(100, 23);
			phoneTextbox.TabIndex = 6;
			phoneTextbox.KeyPress += PhoneNumberOnKeyPress;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(29, 157);
			label3.Name = "label3";
			label3.Size = new Size(99, 15);
			label3.TabIndex = 5;
			label3.Text = "Telefon Numarası";
			// 
			// mailTextbox
			// 
			mailTextbox.Location = new Point(29, 240);
			mailTextbox.Name = "mailTextbox";
			mailTextbox.Size = new Size(100, 23);
			mailTextbox.TabIndex = 8;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(29, 222);
			label4.Name = "label4";
			label4.Size = new Size(66, 15);
			label4.TabIndex = 7;
			label4.Text = "Mail Adresi";
			// 
			// passwordTextbox
			// 
			passwordTextbox.Location = new Point(29, 301);
			passwordTextbox.Name = "passwordTextbox";
			passwordTextbox.PasswordChar = '*';
			passwordTextbox.Size = new Size(100, 23);
			passwordTextbox.TabIndex = 10;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(29, 283);
			label5.Name = "label5";
			label5.Size = new Size(30, 15);
			label5.TabIndex = 9;
			label5.Text = "Şifre";
			// 
			// Signup
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(426, 450);
			Controls.Add(passwordTextbox);
			Controls.Add(label5);
			Controls.Add(mailTextbox);
			Controls.Add(label4);
			Controls.Add(phoneTextbox);
			Controls.Add(label3);
			Controls.Add(surnameTextbox);
			Controls.Add(label2);
			Controls.Add(nameTextbox);
			Controls.Add(submitButton);
			Controls.Add(label1);
			Name = "Signup";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Kayıt Ol";
			Load += Signup_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button submitButton;
		private TextBox nameTextbox;
		private TextBox surnameTextbox;
		private Label label2;
		private TextBox phoneTextbox;
		private Label label3;
		private TextBox mailTextbox;
		private Label label4;
		private TextBox passwordTextbox;
		private Label label5;
	}
}