namespace TicketSystem
{
	partial class Buses
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
			fromComboBox = new ComboBox();
			fromLabel = new Label();
			toComboBox = new ComboBox();
			toLabel = new Label();
			dateTimePicker = new DateTimePicker();
			dateLabel = new Label();
			searchButton = new Button();
			busGrid = new DataGridView();
			fromColumn = new DataGridViewTextBoxColumn();
			toColumn = new DataGridViewTextBoxColumn();
			dateColumn = new DataGridViewTextBoxColumn();
			timeColumn = new DataGridViewTextBoxColumn();
			companyColumn = new DataGridViewTextBoxColumn();
			priceColumn = new DataGridViewTextBoxColumn();
			busTypeColumn = new DataGridViewTextBoxColumn();
			busBrandColumn = new DataGridViewTextBoxColumn();
			errorText = new Label();
			submitButton = new Button();
			((System.ComponentModel.ISupportInitialize)busGrid).BeginInit();
			SuspendLayout();
			// 
			// fromComboBox
			// 
			fromComboBox.FormattingEnabled = true;
			fromComboBox.Items.AddRange(new object[] { "Ankara", "Antalya", "Bursa", "Istanbul", "Izmir", "Konya", "Muğla" });
			fromComboBox.Location = new Point(12, 34);
			fromComboBox.Name = "fromComboBox";
			fromComboBox.Size = new Size(121, 23);
			fromComboBox.TabIndex = 0;
			// 
			// fromLabel
			// 
			fromLabel.AutoSize = true;
			fromLabel.Location = new Point(12, 16);
			fromLabel.Name = "fromLabel";
			fromLabel.Size = new Size(52, 15);
			fromLabel.TabIndex = 1;
			fromLabel.Text = "Nereden";
			// 
			// toComboBox
			// 
			toComboBox.FormattingEnabled = true;
			toComboBox.Items.AddRange(new object[] { "Ankara", "Antalya", "Bursa", "Istanbul", "Izmir", "Konya", "Muğla" });
			toComboBox.Location = new Point(163, 34);
			toComboBox.Name = "toComboBox";
			toComboBox.Size = new Size(121, 23);
			toComboBox.TabIndex = 2;
			// 
			// toLabel
			// 
			toLabel.AutoSize = true;
			toLabel.Location = new Point(163, 16);
			toLabel.Name = "toLabel";
			toLabel.Size = new Size(44, 15);
			toLabel.TabIndex = 3;
			toLabel.Text = "Nereye";
			// 
			// dateTimePicker
			// 
			dateTimePicker.Format = DateTimePickerFormat.Short;
			dateTimePicker.Location = new Point(314, 34);
			dateTimePicker.Name = "dateTimePicker";
			dateTimePicker.Size = new Size(99, 23);
			dateTimePicker.TabIndex = 4;
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new Point(314, 16);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new Size(32, 15);
			dateLabel.TabIndex = 5;
			dateLabel.Text = "Tarih";
			// 
			// searchButton
			// 
			searchButton.Location = new Point(457, 33);
			searchButton.Name = "searchButton";
			searchButton.Size = new Size(75, 23);
			searchButton.TabIndex = 6;
			searchButton.Text = "Sefer Ara";
			searchButton.UseVisualStyleBackColor = true;
			searchButton.Click += SearchButtonOnClick;
			// 
			// busGrid
			// 
			busGrid.AllowUserToAddRows = false;
			busGrid.AllowUserToDeleteRows = false;
			busGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			busGrid.Columns.AddRange(new DataGridViewColumn[] { fromColumn, toColumn, dateColumn, timeColumn, companyColumn, priceColumn, busTypeColumn, busBrandColumn });
			busGrid.Location = new Point(12, 78);
			busGrid.Name = "busGrid";
			busGrid.ReadOnly = true;
			busGrid.RowHeadersVisible = false;
			busGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
			busGrid.Size = new Size(643, 238);
			busGrid.TabIndex = 8;
			busGrid.Visible = false;
			busGrid.CellContentClick += BusGridOnClickCellContent;
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
			// errorText
			// 
			errorText.AutoSize = true;
			errorText.ForeColor = Color.Red;
			errorText.Location = new Point(12, 60);
			errorText.Name = "errorText";
			errorText.Size = new Size(140, 15);
			errorText.TabIndex = 9;
			errorText.Text = "Lütfen Alanları Doldurun!";
			errorText.Visible = false;
			// 
			// submitButton
			// 
			submitButton.Location = new Point(580, 342);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(75, 23);
			submitButton.TabIndex = 10;
			submitButton.Text = "Satın Al";
			submitButton.UseVisualStyleBackColor = true;
			submitButton.Click += SubmitButtonOnClick;
			// 
			// Buses
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(678, 387);
			Controls.Add(submitButton);
			Controls.Add(errorText);
			Controls.Add(busGrid);
			Controls.Add(searchButton);
			Controls.Add(dateLabel);
			Controls.Add(dateTimePicker);
			Controls.Add(toLabel);
			Controls.Add(toComboBox);
			Controls.Add(fromLabel);
			Controls.Add(fromComboBox);
			Name = "Buses";
			Text = "Buses";
			((System.ComponentModel.ISupportInitialize)busGrid).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox fromComboBox;
		private Label fromLabel;
		private ComboBox toComboBox;
		private Label toLabel;
		private DateTimePicker dateTimePicker;
		private Label dateLabel;
		private Button searchButton;
		private DataGridView busGrid;
		private DataGridViewTextBoxColumn fromColumn;
		private DataGridViewTextBoxColumn toColumn;
		private DataGridViewTextBoxColumn dateColumn;
		private DataGridViewTextBoxColumn timeColumn;
		private DataGridViewTextBoxColumn companyColumn;
		private DataGridViewTextBoxColumn priceColumn;
		private DataGridViewTextBoxColumn busTypeColumn;
		private DataGridViewTextBoxColumn busBrandColumn;
		private Label errorText;
		private Button submitButton;
	}
}