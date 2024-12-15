namespace TicketSystem
{
	partial class Payment
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
			nameSurnameText = new TextBox();
			cardNumberText = new TextBox();
			expDateText = new TextBox();
			cvvText = new TextBox();
			errorText = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
			label1.Location = new Point(37, 34);
			label1.Name = "label1";
			label1.Size = new Size(133, 28);
			label1.TabIndex = 0;
			label1.Text = "Kart Bilgileri";
			// 
			// nameSurnameText
			// 
			nameSurnameText.Location = new Point(37, 90);
			nameSurnameText.Name = "nameSurnameText";
			nameSurnameText.PlaceholderText = "Kart Üstündeki İsim";
			nameSurnameText.Size = new Size(215, 23);
			nameSurnameText.TabIndex = 1;
			// 
			// cardNumberText
			// 
			cardNumberText.Location = new Point(37, 140);
			cardNumberText.Name = "cardNumberText";
			cardNumberText.PlaceholderText = "Kart Numarası";
			cardNumberText.Size = new Size(215, 23);
			cardNumberText.TabIndex = 2;
			// 
			// expDateText
			// 
			expDateText.Location = new Point(37, 190);
			expDateText.Name = "expDateText";
			expDateText.PlaceholderText = "SKT";
			expDateText.Size = new Size(85, 23);
			expDateText.TabIndex = 3;
			// 
			// cvvText
			// 
			cvvText.Location = new Point(164, 190);
			cvvText.Name = "cvvText";
			cvvText.PlaceholderText = "CVV";
			cvvText.Size = new Size(88, 23);
			cvvText.TabIndex = 4;
			// 
			// errorText
			// 
			errorText.AutoSize = true;
			errorText.ForeColor = Color.Red;
			errorText.Location = new Point(60, 308);
			errorText.Name = "errorText";
			errorText.Size = new Size(179, 15);
			errorText.TabIndex = 6;
			errorText.Text = "Lütfen Tüm Alanları Doldurunuz!";
			errorText.Visible = false;
			// 
			// Payment
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(289, 355);
			Controls.Add(errorText);
			Controls.Add(cvvText);
			Controls.Add(expDateText);
			Controls.Add(cardNumberText);
			Controls.Add(nameSurnameText);
			Controls.Add(label1);
			Name = "Payment";
			Text = "Ödeme";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox nameSurnameText;
		private TextBox cardNumberText;
		private TextBox expDateText;
		private TextBox cvvText;
		private Label errorText;
	}
}