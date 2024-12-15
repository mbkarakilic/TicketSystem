namespace TicketSystem
{
	partial class Home
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
			dataChart = new MindFusion.Charting.WinForms.LineChart();
			chartChangeButton = new Button();
			panel1 = new Panel();
			label1 = new Label();
			SuspendLayout();
			// 
			// dataChart
			// 
			dataChart.LegendTitle = "Legend";
			dataChart.Location = new Point(12, 26);
			dataChart.Name = "dataChart";
			dataChart.Padding = new Padding(5);
			dataChart.ShowLegend = true;
			dataChart.Size = new Size(654, 310);
			dataChart.SubtitleFontName = null;
			dataChart.SubtitleFontSize = null;
			dataChart.SubtitleFontStyle = null;
			dataChart.TabIndex = 0;
			dataChart.Text = "lineChart1";
			dataChart.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
			dataChart.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
			dataChart.Theme.UniformSeriesStrokeThickness = 2D;
			dataChart.TitleFontName = null;
			dataChart.TitleFontSize = null;
			dataChart.TitleFontStyle = null;
			// 
			// chartChangeButton
			// 
			chartChangeButton.Location = new Point(323, 352);
			chartChangeButton.Name = "chartChangeButton";
			chartChangeButton.Size = new Size(75, 23);
			chartChangeButton.TabIndex = 1;
			chartChangeButton.Text = "Uçaklar";
			chartChangeButton.UseVisualStyleBackColor = true;
			chartChangeButton.Click += ChartChangeButtonOnClick;
			// 
			// panel1
			// 
			panel1.Location = new Point(397, 26);
			panel1.Name = "panel1";
			panel1.Size = new Size(269, 28);
			panel1.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(315, 8);
			label1.Name = "label1";
			label1.Size = new Size(49, 15);
			label1.TabIndex = 3;
			label1.Text = "En Ucuz";
			label1.Click += label1_Click;
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(678, 387);
			Controls.Add(label1);
			Controls.Add(panel1);
			Controls.Add(chartChangeButton);
			Controls.Add(dataChart);
			Name = "Home";
			Text = "Home";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MindFusion.Charting.WinForms.LineChart dataChart;
		private Button chartChangeButton;
		private Panel panel1;
		private Label label1;
	}
}