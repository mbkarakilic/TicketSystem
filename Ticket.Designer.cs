namespace TicketSystem
{
	partial class Ticket
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
			searchButton = new Button();
			pnrTextbox = new TextBox();
			label2 = new Label();
			fromLabel = new Label();
			toLabel = new Label();
			dateLabel = new Label();
			timeLabel = new Label();
			label9 = new Label();
			label10 = new Label();
			label11 = new Label();
			label12 = new Label();
			label13 = new Label();
			label14 = new Label();
			pnrLabel = new Label();
			priceLabel = new Label();
			seatNumberLabel = new Label();
			companyLabel = new Label();
			label19 = new Label();
			deleteButton = new Button();
			panel1 = new Panel();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(15, 17);
			label1.Name = "label1";
			label1.Size = new Size(61, 15);
			label1.TabIndex = 0;
			label1.Text = "PNR Kodu";
			// 
			// searchButton
			// 
			searchButton.Location = new Point(162, 35);
			searchButton.Name = "searchButton";
			searchButton.Size = new Size(75, 23);
			searchButton.TabIndex = 1;
			searchButton.Text = "Ara";
			searchButton.UseVisualStyleBackColor = true;
			searchButton.Click += searchButton_Click;
			// 
			// pnrTextbox
			// 
			pnrTextbox.Location = new Point(15, 35);
			pnrTextbox.Name = "pnrTextbox";
			pnrTextbox.Size = new Size(100, 23);
			pnrTextbox.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.Location = new Point(56, 117);
			label2.Name = "label2";
			label2.Size = new Size(59, 15);
			label2.TabIndex = 3;
			label2.Text = "Nereden:";
			// 
			// fromLabel
			// 
			fromLabel.AutoSize = true;
			fromLabel.Location = new Point(121, 117);
			fromLabel.Name = "fromLabel";
			fromLabel.Size = new Size(38, 15);
			fromLabel.TabIndex = 4;
			fromLabel.Text = "label3";
			// 
			// toLabel
			// 
			toLabel.AutoSize = true;
			toLabel.Location = new Point(113, 147);
			toLabel.Name = "toLabel";
			toLabel.Size = new Size(38, 15);
			toLabel.TabIndex = 5;
			toLabel.Text = "label4";
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new Point(99, 177);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new Size(38, 15);
			dateLabel.TabIndex = 6;
			dateLabel.Text = "label5";
			// 
			// timeLabel
			// 
			timeLabel.AutoSize = true;
			timeLabel.Location = new Point(96, 207);
			timeLabel.Name = "timeLabel";
			timeLabel.Size = new Size(38, 15);
			timeLabel.TabIndex = 7;
			timeLabel.Text = "label6";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label9.Location = new Point(56, 147);
			label9.Name = "label9";
			label9.Size = new Size(51, 15);
			label9.TabIndex = 10;
			label9.Text = "Nereye:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label10.Location = new Point(56, 177);
			label10.Name = "label10";
			label10.Size = new Size(37, 15);
			label10.TabIndex = 11;
			label10.Text = "Tarih:";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label11.Location = new Point(56, 207);
			label11.Name = "label11";
			label11.Size = new Size(34, 15);
			label11.TabIndex = 12;
			label11.Text = "Saat:";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label12.Location = new Point(202, 207);
			label12.Name = "label12";
			label12.Size = new Size(34, 15);
			label12.TabIndex = 20;
			label12.Text = "PNR:";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label13.Location = new Point(202, 177);
			label13.Name = "label13";
			label13.Size = new Size(36, 15);
			label13.TabIndex = 19;
			label13.Text = "Fiyat:";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label14.Location = new Point(202, 147);
			label14.Name = "label14";
			label14.Size = new Size(102, 15);
			label14.TabIndex = 18;
			label14.Text = "Koltuk Numarası:";
			// 
			// pnrLabel
			// 
			pnrLabel.AutoSize = true;
			pnrLabel.Location = new Point(242, 207);
			pnrLabel.Name = "pnrLabel";
			pnrLabel.Size = new Size(44, 15);
			pnrLabel.TabIndex = 17;
			pnrLabel.Text = "label15";
			// 
			// priceLabel
			// 
			priceLabel.AutoSize = true;
			priceLabel.Location = new Point(245, 177);
			priceLabel.Name = "priceLabel";
			priceLabel.Size = new Size(44, 15);
			priceLabel.TabIndex = 16;
			priceLabel.Text = "label16";
			// 
			// seatNumberLabel
			// 
			seatNumberLabel.AutoSize = true;
			seatNumberLabel.Location = new Point(310, 147);
			seatNumberLabel.Name = "seatNumberLabel";
			seatNumberLabel.Size = new Size(44, 15);
			seatNumberLabel.TabIndex = 15;
			seatNumberLabel.Text = "label17";
			// 
			// companyLabel
			// 
			companyLabel.AutoSize = true;
			companyLabel.Location = new Point(249, 117);
			companyLabel.Name = "companyLabel";
			companyLabel.Size = new Size(44, 15);
			companyLabel.TabIndex = 14;
			companyLabel.Text = "label18";
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label19.Location = new Point(202, 117);
			label19.Name = "label19";
			label19.Size = new Size(41, 15);
			label19.TabIndex = 13;
			label19.Text = "Firma:";
			// 
			// deleteButton
			// 
			deleteButton.Location = new Point(437, 207);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(75, 23);
			deleteButton.TabIndex = 21;
			deleteButton.Text = "İptal Et";
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Click += DeleteButtonOnClick;
			// 
			// panel1
			// 
			panel1.Location = new Point(35, 75);
			panel1.Name = "panel1";
			panel1.Size = new Size(558, 247);
			panel1.TabIndex = 22;
			// 
			// Ticket
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(678, 387);
			Controls.Add(panel1);
			Controls.Add(deleteButton);
			Controls.Add(label12);
			Controls.Add(label13);
			Controls.Add(label14);
			Controls.Add(pnrLabel);
			Controls.Add(priceLabel);
			Controls.Add(seatNumberLabel);
			Controls.Add(companyLabel);
			Controls.Add(label19);
			Controls.Add(label11);
			Controls.Add(label10);
			Controls.Add(label9);
			Controls.Add(timeLabel);
			Controls.Add(dateLabel);
			Controls.Add(toLabel);
			Controls.Add(fromLabel);
			Controls.Add(label2);
			Controls.Add(pnrTextbox);
			Controls.Add(searchButton);
			Controls.Add(label1);
			Name = "Ticket";
			Text = "Ticket";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button searchButton;
		private TextBox pnrTextbox;
		private Label label2;
		private Label fromLabel;
		private Label toLabel;
		private Label dateLabel;
		private Label timeLabel;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label14;
		private Label pnrLabel;
		private Label priceLabel;
		private Label seatNumberLabel;
		private Label companyLabel;
		private Label label19;
		private Button deleteButton;
		private Panel panel1;
	}
}