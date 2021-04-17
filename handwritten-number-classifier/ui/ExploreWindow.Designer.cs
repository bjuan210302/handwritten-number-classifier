using System.ComponentModel;

namespace handwritten_number_classifier.ui
{
    partial class ExploreWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExploreWindow));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.NumberImage = new System.Windows.Forms.PictureBox();
            this.prevBut = new System.Windows.Forms.Button();
            this.nextBut = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.searchBut = new System.Windows.Forms.Button();
            this.idxLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearBut = new System.Windows.Forms.Button();
            this.histogramGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.viewChartsBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.NumberImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.histogramGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberImage
            // 
            this.NumberImage.Location = new System.Drawing.Point(36, 31);
            this.NumberImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumberImage.Name = "NumberImage";
            this.NumberImage.Size = new System.Drawing.Size(280, 281);
            this.NumberImage.TabIndex = 0;
            this.NumberImage.TabStop = false;
            // 
            // prevBut
            // 
            this.prevBut.Image = ((System.Drawing.Image) (resources.GetObject("prevBut.Image")));
            this.prevBut.Location = new System.Drawing.Point(83, 335);
            this.prevBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevBut.Name = "prevBut";
            this.prevBut.Size = new System.Drawing.Size(45, 52);
            this.prevBut.TabIndex = 1;
            this.prevBut.UseVisualStyleBackColor = true;
            this.prevBut.Click += new System.EventHandler(this.prevBut_Click);
            // 
            // nextBut
            // 
            this.nextBut.Image = ((System.Drawing.Image) (resources.GetObject("nextBut.Image")));
            this.nextBut.Location = new System.Drawing.Point(209, 335);
            this.nextBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextBut.Name = "nextBut";
            this.nextBut.Size = new System.Drawing.Size(45, 52);
            this.nextBut.TabIndex = 2;
            this.nextBut.UseVisualStyleBackColor = true;
            this.nextBut.Click += new System.EventHandler(this.nextBut_Click);
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(341, 44);
            this.searchField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(211, 22);
            this.searchField.TabIndex = 3;
            // 
            // searchBut
            // 
            this.searchBut.Image = ((System.Drawing.Image) (resources.GetObject("searchBut.Image")));
            this.searchBut.Location = new System.Drawing.Point(573, 39);
            this.searchBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(43, 32);
            this.searchBut.TabIndex = 4;
            this.searchBut.UseVisualStyleBackColor = true;
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // idxLabel
            // 
            this.idxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.idxLabel.Location = new System.Drawing.Point(65, 422);
            this.idxLabel.Name = "idxLabel";
            this.idxLabel.Size = new System.Drawing.Size(65, 25);
            this.idxLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(136, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "of 10000";
            // 
            // clearBut
            // 
            this.clearBut.Location = new System.Drawing.Point(643, 39);
            this.clearBut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(100, 32);
            this.clearBut.TabIndex = 7;
            this.clearBut.Text = "Clear filters";
            this.clearBut.UseVisualStyleBackColor = true;
            this.clearBut.Click += new System.EventHandler(this.clearBut_Click);
            // 
            // histogramGraph
            // 
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.histogramGraph.ChartAreas.Add(chartArea1);
            this.histogramGraph.Location = new System.Drawing.Point(341, 98);
            this.histogramGraph.Margin = new System.Windows.Forms.Padding(4);
            this.histogramGraph.Name = "histogramGraph";
            this.histogramGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.histogramGraph.PaletteCustomColors = new System.Drawing.Color[] {System.Drawing.Color.Black};
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.histogramGraph.Series.Add(series1);
            this.histogramGraph.Size = new System.Drawing.Size(657, 337);
            this.histogramGraph.TabIndex = 8;
            this.histogramGraph.Text = "chart1";
            // 
            // viewChartsBut
            // 
            this.viewChartsBut.Location = new System.Drawing.Point(780, 39);
            this.viewChartsBut.Name = "viewChartsBut";
            this.viewChartsBut.Size = new System.Drawing.Size(158, 32);
            this.viewChartsBut.TabIndex = 9;
            this.viewChartsBut.Text = "View other charts";
            this.viewChartsBut.UseVisualStyleBackColor = true;
            this.viewChartsBut.Click += new System.EventHandler(this.viewChartsBut_Click);
            // 
            // ExploreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1015, 450);
            this.Controls.Add(this.viewChartsBut);
            this.Controls.Add(this.histogramGraph);
            this.Controls.Add(this.clearBut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idxLabel);
            this.Controls.Add(this.searchBut);
            this.Controls.Add(this.searchField);
            this.Controls.Add(this.nextBut);
            this.Controls.Add(this.prevBut);
            this.Controls.Add(this.NumberImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ExploreWindow";
            ((System.ComponentModel.ISupportInitialize) (this.NumberImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.histogramGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button viewChartsBut;

        private System.Windows.Forms.DataVisualization.Charting.Chart histogramGraph;

        private System.Windows.Forms.Button clearBut;

        private System.Windows.Forms.Label idxLabel;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button searchBut;
        private System.Windows.Forms.TextBox searchField;

        private System.Windows.Forms.Button prevBut;
        private System.Windows.Forms.Button nextBut;

        private System.Windows.Forms.PictureBox NumberImage;

        #endregion
    }
}