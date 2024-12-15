namespace TicketSystem
{
	partial class ChangePassword
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
			label2 = new Label();
			label3 = new Label();
			oldPasswordTextbox = new TextBox();
			newPasswordTextBox = new TextBox();
			newPasswordAgainTextBox = new TextBox();
			submitButton = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(109, 207);
			label1.Name = "label1";
			label1.Size = new Size(89, 15);
			label1.TabIndex = 0;
			label1.Text = "Yeni Şifre Tekrar";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(109, 142);
			label2.Name = "label2";
			label2.Size = new Size(55, 15);
			label2.TabIndex = 1;
			label2.Text = "Yeni Şifre";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(109, 77);
			label3.Name = "label3";
			label3.Size = new Size(53, 15);
			label3.TabIndex = 2;
			label3.Text = "Eski Şifre";
			// 
			// oldPasswordTextbox
			// 
			oldPasswordTextbox.Location = new Point(109, 95);
			oldPasswordTextbox.Name = "oldPasswordTextbox";
			oldPasswordTextbox.PasswordChar = '*';
			oldPasswordTextbox.Size = new Size(100, 23);
			oldPasswordTextbox.TabIndex = 3;
			// 
			// newPasswordTextBox
			// 
			newPasswordTextBox.Location = new Point(109, 160);
			newPasswordTextBox.Name = "newPasswordTextBox";
			newPasswordTextBox.PasswordChar = '*';
			newPasswordTextBox.Size = new Size(100, 23);
			newPasswordTextBox.TabIndex = 4;
			// 
			// newPasswordAgainTextBox
			// 
			newPasswordAgainTextBox.Location = new Point(109, 225);
			newPasswordAgainTextBox.Name = "newPasswordAgainTextBox";
			newPasswordAgainTextBox.PasswordChar = '*';
			newPasswordAgainTextBox.Size = new Size(100, 23);
			newPasswordAgainTextBox.TabIndex = 5;
			// 
			// submitButton
			// 
			submitButton.Location = new Point(123, 306);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(75, 23);
			submitButton.TabIndex = 6;
			submitButton.Text = "Değiştir";
			submitButton.UseVisualStyleBackColor = true;
			submitButton.Click += SubmitButtonOnClick;
			// 
			// ChangePassword
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(387, 450);
			Controls.Add(submitButton);
			Controls.Add(newPasswordAgainTextBox);
			Controls.Add(newPasswordTextBox);
			Controls.Add(oldPasswordTextbox);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ChangePassword";
			Text = "ChangePassword";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox oldPasswordTextbox;
		private TextBox newPasswordTextBox;
		private TextBox newPasswordAgainTextBox;
		private Button submitButton;
	}
}