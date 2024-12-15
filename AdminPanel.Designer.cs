namespace TicketSystem
{
	partial class AdminPanel
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
			deleteTravelButton = new Button();
			errorText = new Label();
			travelsGrid = new DataGridView();
			fromColumn = new DataGridViewTextBoxColumn();
			toColumn = new DataGridViewTextBoxColumn();
			dateColumn = new DataGridViewTextBoxColumn();
			timeColumn = new DataGridViewTextBoxColumn();
			companyColumn = new DataGridViewTextBoxColumn();
			priceColumn = new DataGridViewTextBoxColumn();
			busTypeColumn = new DataGridViewTextBoxColumn();
			busBrandColumn = new DataGridViewTextBoxColumn();
			searchButton = new Button();
			dateLabel = new Label();
			dateTimePicker = new DateTimePicker();
			toLabel = new Label();
			toComboBox = new ComboBox();
			fromLabel = new Label();
			fromComboBox = new ComboBox();
			addTravelButton = new Button();
			label1 = new Label();
			typeComboBox = new ComboBox();
			((System.ComponentModel.ISupportInitialize)travelsGrid).BeginInit();
			SuspendLayout();
			// 
			// deleteTravelButton
			// 
			deleteTravelButton.Location = new Point(586, 345);
			deleteTravelButton.Name = "deleteTravelButton";
			deleteTravelButton.Size = new Size(75, 23);
			deleteTravelButton.TabIndex = 20;
			deleteTravelButton.Text = "Seferi Sil";
			deleteTravelButton.UseVisualStyleBackColor = true;
			deleteTravelButton.Visible = false;
			deleteTravelButton.Click += DeleteTravelButtonOnClick;
			// 
			// errorText
			// 
			errorText.AutoSize = true;
			errorText.ForeColor = Color.Red;
			errorText.Location = new Point(18, 63);
			errorText.Name = "errorText";
			errorText.Size = new Size(140, 15);
			errorText.TabIndex = 19;
			errorText.Text = "Lütfen Alanları Doldurun!";
			errorText.Visible = false;
			// 
			// travelsGrid
			// 
			travelsGrid.AllowUserToAddRows = false;
			travelsGrid.AllowUserToDeleteRows = false;
			travelsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			travelsGrid.Columns.AddRange(new DataGridViewColumn[] { fromColumn, toColumn, dateColumn, timeColumn, companyColumn, priceColumn, busTypeColumn, busBrandColumn });
			travelsGrid.Location = new Point(18, 81);
			travelsGrid.Name = "travelsGrid";
			travelsGrid.ReadOnly = true;
			travelsGrid.RowHeadersVisible = false;
			travelsGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
			travelsGrid.Size = new Size(643, 238);
			travelsGrid.TabIndex = 18;
			travelsGrid.Visible = false;
			travelsGrid.CellContentClick += TravelsGridOnCellContentSelect;
			// 
			// fromColumn
			// 
			fromColumn.HeaderText = "NEREDEN";
			fromColumn.Name = "fromColumn";
			fromColumn.ReadOnly = true;
			fromColumn.Resizable = DataGridViewTriState.False;
			fromColumn.Width = 80;
			// 
			// toColumn
			// 
			toColumn.HeaderText = "NEREYE";
			toColumn.Name = "toColumn";
			toColumn.ReadOnly = true;
			toColumn.Resizable = DataGridViewTriState.False;
			toColumn.Width = 80;
			// 
			// dateColumn
			// 
			dateColumn.HeaderText = "TARİH";
			dateColumn.Name = "dateColumn";
			dateColumn.ReadOnly = true;
			dateColumn.Resizable = DataGridViewTriState.False;
			dateColumn.Width = 80;
			// 
			// timeColumn
			// 
			timeColumn.HeaderText = "SAAT";
			timeColumn.Name = "timeColumn";
			timeColumn.ReadOnly = true;
			timeColumn.Resizable = DataGridViewTriState.False;
			timeColumn.Width = 80;
			// 
			// companyColumn
			// 
			companyColumn.HeaderText = "FİRMA";
			companyColumn.Name = "companyColumn";
			companyColumn.ReadOnly = true;
			companyColumn.Resizable = DataGridViewTriState.False;
			companyColumn.Width = 80;
			// 
			// priceColumn
			// 
			priceColumn.HeaderText = "FİYAT";
			priceColumn.Name = "priceColumn";
			priceColumn.ReadOnly = true;
			priceColumn.Resizable = DataGridViewTriState.False;
			priceColumn.Width = 80;
			// 
			// busTypeColumn
			// 
			busTypeColumn.HeaderText = "OTOBÜS TİPİ";
			busTypeColumn.Name = "busTypeColumn";
			busTypeColumn.ReadOnly = true;
			busTypeColumn.Resizable = DataGridViewTriState.False;
			busTypeColumn.Width = 80;
			// 
			// busBrandColumn
			// 
			busBrandColumn.HeaderText = "O. MARKA";
			busBrandColumn.Name = "busBrandColumn";
			busBrandColumn.ReadOnly = true;
			busBrandColumn.Resizable = DataGridViewTriState.False;
			busBrandColumn.Width = 80;
			// 
			// searchButton
			// 
			searchButton.Location = new Point(586, 37);
			searchButton.Name = "searchButton";
			searchButton.Size = new Size(75, 23);
			searchButton.TabIndex = 17;
			searchButton.Text = "Sefer Ara";
			searchButton.UseVisualStyleBackColor = true;
			searchButton.Click += SearchButtonOnClick;
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new Point(464, 19);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new Size(32, 15);
			dateLabel.TabIndex = 16;
			dateLabel.Text = "Tarih";
			// 
			// dateTimePicker
			// 
			dateTimePicker.Format = DateTimePickerFormat.Short;
			dateTimePicker.Location = new Point(464, 37);
			dateTimePicker.Name = "dateTimePicker";
			dateTimePicker.Size = new Size(99, 23);
			dateTimePicker.TabIndex = 15;
			// 
			// toLabel
			// 
			toLabel.AutoSize = true;
			toLabel.Location = new Point(167, 19);
			toLabel.Name = "toLabel";
			toLabel.Size = new Size(44, 15);
			toLabel.TabIndex = 14;
			toLabel.Text = "Nereye";
			// 
			// toComboBox
			// 
			toComboBox.FormattingEnabled = true;
			toComboBox.Items.AddRange(new object[] { "Ankara", "Antalya", "Bursa", "Istanbul", "Izmir", "Konya", "Muğla" });
			toComboBox.Location = new Point(167, 37);
			toComboBox.Name = "toComboBox";
			toComboBox.Size = new Size(121, 23);
			toComboBox.TabIndex = 13;
			// 
			// fromLabel
			// 
			fromLabel.AutoSize = true;
			fromLabel.Location = new Point(18, 19);
			fromLabel.Name = "fromLabel";
			fromLabel.Size = new Size(52, 15);
			fromLabel.TabIndex = 12;
			fromLabel.Text = "Nereden";
			// 
			// fromComboBox
			// 
			fromComboBox.FormattingEnabled = true;
			fromComboBox.Items.AddRange(new object[] { "Ankara", "Antalya", "Bursa", "Istanbul", "Izmir", "Konya", "Muğla" });
			fromComboBox.Location = new Point(18, 37);
			fromComboBox.Name = "fromComboBox";
			fromComboBox.Size = new Size(121, 23);
			fromComboBox.TabIndex = 11;
			// 
			// addTravelButton
			// 
			addTravelButton.Location = new Point(18, 345);
			addTravelButton.Name = "addTravelButton";
			addTravelButton.Size = new Size(75, 23);
			addTravelButton.TabIndex = 21;
			addTravelButton.Text = "Sefer Ekle";
			addTravelButton.UseVisualStyleBackColor = true;
			addTravelButton.Click += AddTravelButtonOnClick;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(314, 19);
			label1.Name = "label1";
			label1.Size = new Size(24, 15);
			label1.TabIndex = 23;
			label1.Text = "Tür";
			// 
			// typeComboBox
			// 
			typeComboBox.FormattingEnabled = true;
			typeComboBox.Items.AddRange(new object[] { "Otobüs", "Uçak", "Tren" });
			typeComboBox.Location = new Point(314, 37);
			typeComboBox.Name = "typeComboBox";
			typeComboBox.Size = new Size(121, 23);
			typeComboBox.TabIndex = 22;
			// 
			// AdminPanel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(678, 387);
			Controls.Add(label1);
			Controls.Add(typeComboBox);
			Controls.Add(addTravelButton);
			Controls.Add(deleteTravelButton);
			Controls.Add(errorText);
			Controls.Add(travelsGrid);
			Controls.Add(searchButton);
			Controls.Add(dateLabel);
			Controls.Add(dateTimePicker);
			Controls.Add(toLabel);
			Controls.Add(toComboBox);
			Controls.Add(fromLabel);
			Controls.Add(fromComboBox);
			Name = "AdminPanel";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "AdminPanel";
			((System.ComponentModel.ISupportInitialize)travelsGrid).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button deleteTravelButton;
		private Label errorText;
		private DataGridView travelsGrid;
		private DataGridViewTextBoxColumn fromColumn;
		private DataGridViewTextBoxColumn toColumn;
		private DataGridViewTextBoxColumn dateColumn;
		private DataGridViewTextBoxColumn timeColumn;
		private DataGridViewTextBoxColumn companyColumn;
		private DataGridViewTextBoxColumn priceColumn;
		private DataGridViewTextBoxColumn busTypeColumn;
		private DataGridViewTextBoxColumn busBrandColumn;
		private Button searchButton;
		private Label dateLabel;
		private DateTimePicker dateTimePicker;
		private Label toLabel;
		private ComboBox toComboBox;
		private Label fromLabel;
		private ComboBox fromComboBox;
		private Button addTravelButton;
		private Label label1;
		private ComboBox typeComboBox;
	}
}