namespace TicketSystem
{
	partial class AddTravel
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
			typeComboBox = new ComboBox();
			errorText = new Label();
			submitButton = new Button();
			dateLabel = new Label();
			dateTimePicker = new DateTimePicker();
			toLabel = new Label();
			toComboBox = new ComboBox();
			fromLabel = new Label();
			fromComboBox = new ComboBox();
			label2 = new Label();
			vehicleComboBox = new ComboBox();
			priceTextBox = new TextBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			companyComboBox = new ComboBox();
			timeTextBox = new TextBox();
			sameCityErrorText = new Label();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(24, 83);
			label1.Name = "label1";
			label1.Size = new Size(24, 15);
			label1.TabIndex = 33;
			label1.Text = "Tür";
			// 
			// typeComboBox
			// 
			typeComboBox.FormattingEnabled = true;
			typeComboBox.Items.AddRange(new object[] { "Otobüs", "Uçak", "Tren" });
			typeComboBox.Location = new Point(24, 101);
			typeComboBox.Name = "typeComboBox";
			typeComboBox.Size = new Size(121, 23);
			typeComboBox.TabIndex = 32;
			typeComboBox.SelectedIndexChanged += TypeComboBoxSelectedIndexChanged;
			// 
			// errorText
			// 
			errorText.AutoSize = true;
			errorText.ForeColor = Color.Red;
			errorText.Location = new Point(87, 369);
			errorText.Name = "errorText";
			errorText.Size = new Size(140, 15);
			errorText.TabIndex = 31;
			errorText.Text = "Lütfen Alanları Doldurun!";
			errorText.Visible = false;
			// 
			// submitButton
			// 
			submitButton.Location = new Point(116, 333);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(75, 23);
			submitButton.TabIndex = 30;
			submitButton.Text = "Sefer Ekle";
			submitButton.UseVisualStyleBackColor = true;
			submitButton.Click += SubmitButtonOnClick;
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new Point(24, 145);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new Size(32, 15);
			dateLabel.TabIndex = 29;
			dateLabel.Text = "Tarih";
			// 
			// dateTimePicker
			// 
			dateTimePicker.Format = DateTimePickerFormat.Short;
			dateTimePicker.Location = new Point(24, 163);
			dateTimePicker.Name = "dateTimePicker";
			dateTimePicker.Size = new Size(121, 23);
			dateTimePicker.TabIndex = 28;
			dateTimePicker.ValueChanged += DateTimePickerOnValueChanged;
			// 
			// toLabel
			// 
			toLabel.AutoSize = true;
			toLabel.Location = new Point(176, 26);
			toLabel.Name = "toLabel";
			toLabel.Size = new Size(44, 15);
			toLabel.TabIndex = 27;
			toLabel.Text = "Nereye";
			// 
			// toComboBox
			// 
			toComboBox.FormattingEnabled = true;
			toComboBox.Items.AddRange(new object[] { "Ankara", "Antalya", "Bursa", "Istanbul", "Izmir", "Konya", "Muğla" });
			toComboBox.Location = new Point(176, 44);
			toComboBox.Name = "toComboBox";
			toComboBox.Size = new Size(121, 23);
			toComboBox.TabIndex = 26;
			toComboBox.SelectedIndexChanged += ToComboBoxOnSelectedIndexChanged;
			// 
			// fromLabel
			// 
			fromLabel.AutoSize = true;
			fromLabel.Location = new Point(24, 26);
			fromLabel.Name = "fromLabel";
			fromLabel.Size = new Size(52, 15);
			fromLabel.TabIndex = 25;
			fromLabel.Text = "Nereden";
			// 
			// fromComboBox
			// 
			fromComboBox.FormattingEnabled = true;
			fromComboBox.Items.AddRange(new object[] { "Ankara", "Antalya", "Bursa", "Istanbul", "Izmir", "Konya", "Muğla" });
			fromComboBox.Location = new Point(24, 44);
			fromComboBox.Name = "fromComboBox";
			fromComboBox.Size = new Size(121, 23);
			fromComboBox.TabIndex = 24;
			fromComboBox.SelectedIndexChanged += FromComboBoxOnSelectedIndexChanged;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(176, 83);
			label2.Name = "label2";
			label2.Size = new Size(31, 15);
			label2.TabIndex = 35;
			label2.Text = "Araç";
			// 
			// vehicleComboBox
			// 
			vehicleComboBox.Enabled = false;
			vehicleComboBox.FormattingEnabled = true;
			vehicleComboBox.Items.AddRange(new object[] { "Otobüs", "Uçak", "Tren" });
			vehicleComboBox.Location = new Point(176, 101);
			vehicleComboBox.Name = "vehicleComboBox";
			vehicleComboBox.Size = new Size(121, 23);
			vehicleComboBox.TabIndex = 34;
			vehicleComboBox.SelectedIndexChanged += VehicleComboBoxOnSelectedIndexChanged;
			// 
			// priceTextBox
			// 
			priceTextBox.Location = new Point(176, 230);
			priceTextBox.Name = "priceTextBox";
			priceTextBox.Size = new Size(122, 23);
			priceTextBox.TabIndex = 36;
			priceTextBox.TextChanged += PriceTextBoxOmTextChanged;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(176, 212);
			label3.Name = "label3";
			label3.Size = new Size(32, 15);
			label3.TabIndex = 37;
			label3.Text = "Fiyat";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(176, 145);
			label4.Name = "label4";
			label4.Size = new Size(29, 15);
			label4.TabIndex = 39;
			label4.Text = "Saat";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(24, 212);
			label5.Name = "label5";
			label5.Size = new Size(37, 15);
			label5.TabIndex = 41;
			label5.Text = "Firma";
			// 
			// companyComboBox
			// 
			companyComboBox.Enabled = false;
			companyComboBox.FormattingEnabled = true;
			companyComboBox.Items.AddRange(new object[] { "Otobüs", "Uçak", "Tren" });
			companyComboBox.Location = new Point(24, 230);
			companyComboBox.Name = "companyComboBox";
			companyComboBox.Size = new Size(121, 23);
			companyComboBox.TabIndex = 42;
			companyComboBox.SelectedIndexChanged += CompanyComboBoxOnSelectedIndexChanged;
			// 
			// timeTextBox
			// 
			timeTextBox.Location = new Point(175, 166);
			timeTextBox.Name = "timeTextBox";
			timeTextBox.Size = new Size(122, 23);
			timeTextBox.TabIndex = 43;
			timeTextBox.TextChanged += timeTextBox_TextChanged;
			// 
			// sameCityErrorText
			// 
			sameCityErrorText.AutoSize = true;
			sameCityErrorText.ForeColor = Color.Red;
			sameCityErrorText.Location = new Point(87, 384);
			sameCityErrorText.Name = "sameCityErrorText";
			sameCityErrorText.Size = new Size(158, 15);
			sameCityErrorText.TabIndex = 44;
			sameCityErrorText.Text = "Lütfen İki Farklı Şehir Seçiniz.";
			sameCityErrorText.Visible = false;
			// 
			// AddTravel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(323, 421);
			Controls.Add(sameCityErrorText);
			Controls.Add(timeTextBox);
			Controls.Add(companyComboBox);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(priceTextBox);
			Controls.Add(label2);
			Controls.Add(vehicleComboBox);
			Controls.Add(label1);
			Controls.Add(typeComboBox);
			Controls.Add(errorText);
			Controls.Add(submitButton);
			Controls.Add(dateLabel);
			Controls.Add(dateTimePicker);
			Controls.Add(toLabel);
			Controls.Add(toComboBox);
			Controls.Add(fromLabel);
			Controls.Add(fromComboBox);
			Name = "AddTravel";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Sefer Ekle";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private ComboBox typeComboBox;
		private Label errorText;
		private Button submitButton;
		private Label dateLabel;
		private DateTimePicker dateTimePicker;
		private Label toLabel;
		private ComboBox toComboBox;
		private Label fromLabel;
		private ComboBox fromComboBox;
		private Label label2;
		private ComboBox vehicleComboBox;
		private TextBox priceTextBox;
		private Label label3;
		private Label label4;
		private Label label5;
		private ComboBox companyComboBox;
		private TextBox timeTextBox;
		private Label sameCityErrorText;
	}
}