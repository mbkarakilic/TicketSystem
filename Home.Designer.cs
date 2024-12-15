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
			busChart = new MindFusion.Charting.WinForms.LineChart();
			trainChart = new MindFusion.Charting.WinForms.LineChart();
			airplaneChart = new MindFusion.Charting.WinForms.LineChart();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			SuspendLayout();
			// 
			// busChart
			// 
			busChart.LegendTitle = "Legend";
			busChart.Location = new Point(12, 26);
			busChart.Name = "busChart";
			busChart.Padding = new Padding(5);
			busChart.ShowLegend = true;
			busChart.Size = new Size(272, 148);
			busChart.SubtitleFontName = null;
			busChart.SubtitleFontSize = null;
			busChart.SubtitleFontStyle = null;
			busChart.TabIndex = 0;
			busChart.Text = "lineChart1";
			busChart.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
			busChart.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
			busChart.Theme.UniformSeriesStrokeThickness = 2D;
			busChart.TitleFontName = null;
			busChart.TitleFontSize = null;
			busChart.TitleFontStyle = null;
			// 
			// trainChart
			// 
			trainChart.LegendTitle = "Legend";
			trainChart.Location = new Point(198, 227);
			trainChart.Name = "trainChart";
			trainChart.Padding = new Padding(5);
			trainChart.ShowLegend = true;
			trainChart.Size = new Size(272, 148);
			trainChart.SubtitleFontName = null;
			trainChart.SubtitleFontSize = null;
			trainChart.SubtitleFontStyle = null;
			trainChart.TabIndex = 1;
			trainChart.Text = "lineChart2";
			trainChart.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
			trainChart.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
			trainChart.Theme.UniformSeriesStrokeThickness = 2D;
			trainChart.TitleFontName = null;
			trainChart.TitleFontSize = null;
			trainChart.TitleFontStyle = null;
			// 
			// airplaneChart
			// 
			airplaneChart.LegendTitle = "Legend";
			airplaneChart.Location = new Point(394, 25);
			airplaneChart.Name = "airplaneChart";
			airplaneChart.Padding = new Padding(5);
			airplaneChart.ShowLegend = true;
			airplaneChart.Size = new Size(272, 148);
			airplaneChart.SubtitleFontName = null;
			airplaneChart.SubtitleFontSize = null;
			airplaneChart.SubtitleFontStyle = null;
			airplaneChart.TabIndex = 2;
			airplaneChart.Text = "lineChart3";
			airplaneChart.Theme.UniformSeriesFill = new MindFusion.Drawing.SolidBrush("#FF90EE90");
			airplaneChart.Theme.UniformSeriesStroke = new MindFusion.Drawing.SolidBrush("#FF000000");
			airplaneChart.Theme.UniformSeriesStrokeThickness = 2D;
			airplaneChart.TitleFontName = null;
			airplaneChart.TitleFontSize = null;
			airplaneChart.TitleFontStyle = null;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(76, 9);
			label1.Name = "label1";
			label1.Size = new Size(172, 15);
			label1.TabIndex = 3;
			label1.Text = "Günün En Ucuz Otobüs Biletleri";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(470, 9);
			label2.Name = "label2";
			label2.Size = new Size(159, 15);
			label2.TabIndex = 4;
			label2.Text = "Günün En Ucuz Uçak Biletleri";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(267, 209);
			label3.Name = "label3";
			label3.Size = new Size(155, 15);
			label3.TabIndex = 5;
			label3.Text = "Günün En Ucuz Tren Biletleri";
			// 
			// Home
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(678, 387);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(airplaneChart);
			Controls.Add(trainChart);
			Controls.Add(busChart);
			Name = "Home";
			Text = "Home";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MindFusion.Charting.WinForms.LineChart busChart;
		private MindFusion.Charting.WinForms.LineChart trainChart;
		private MindFusion.Charting.WinForms.LineChart airplaneChart;
		private Label label1;
		private Label label2;
		private Label label3;
	}
}