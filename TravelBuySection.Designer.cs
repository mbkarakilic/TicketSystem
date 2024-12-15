namespace TicketSystem
{
	partial class TravelBuySection
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
			panel = new Panel();
			submitButton = new Button();
			backButton = new Button();
			SuspendLayout();
			// 
			// panel
			// 
			panel.Location = new Point(12, 12);
			panel.Name = "panel";
			panel.Size = new Size(776, 383);
			panel.TabIndex = 0;
			// 
			// submitButton
			// 
			submitButton.Location = new Point(713, 415);
			submitButton.Name = "submitButton";
			submitButton.Size = new Size(75, 23);
			submitButton.TabIndex = 1;
			submitButton.Text = "Seç";
			submitButton.UseVisualStyleBackColor = true;
			submitButton.Click += SubmitButtonOnClick;
			// 
			// backButton
			// 
			backButton.Location = new Point(632, 415);
			backButton.Name = "backButton";
			backButton.Size = new Size(75, 23);
			backButton.TabIndex = 2;
			backButton.Text = "Geri";
			backButton.UseVisualStyleBackColor = true;
			backButton.Click += BackButtonOnClick;
			// 
			// TravelBuySection
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(backButton);
			Controls.Add(submitButton);
			Controls.Add(panel);
			Name = "TravelBuySection";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Bilet";
			ResumeLayout(false);
		}

		#endregion

		private Panel panel;
		private Button submitButton;
		private Button backButton;
	}
}