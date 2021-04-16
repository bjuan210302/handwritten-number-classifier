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
            ((System.ComponentModel.ISupportInitialize) (this.NumberImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.histogramGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberImage
            // 
            this.NumberImage.Location = new System.Drawing.Point(27, 25);
            this.NumberImage.Margin = new System.Windows.Forms.Padding(2);
            this.NumberImage.Name = "NumberImage";
            this.NumberImage.Size = new System.Drawing.Size(210, 228);
            this.NumberImage.TabIndex = 0;
            this.NumberImage.TabStop = false;
            // 
            // prevBut
            // 
            this.prevBut.Image = ((System.Drawing.Image) (resources.GetObject("prevBut.Image")));
            this.prevBut.Location = new System.Drawing.Point(62, 272);
            this.prevBut.Margin = new System.Windows.Forms.Padding(2);
            this.prevBut.Name = "prevBut";
            this.prevBut.Size = new System.Drawing.Size(34, 42);
            this.prevBut.TabIndex = 1;
            this.prevBut.UseVisualStyleBackColor = true;
            this.prevBut.Click += new System.EventHandler(this.prevBut_Click);
            // 
            // nextBut
            // 
            this.nextBut.Image = ((System.Drawing.Image) (resources.GetObject("nextBut.Image")));
            this.nextBut.Location = new System.Drawing.Point(157, 272);
            this.nextBut.Margin = new System.Windows.Forms.Padding(2);
            this.nextBut.Name = "nextBut";
            this.nextBut.Size = new System.Drawing.Size(34, 42);
            this.nextBut.TabIndex = 2;
            this.nextBut.UseVisualStyleBackColor = true;
            this.nextBut.Click += new System.EventHandler(this.nextBut_Click);
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(256, 36);
            this.searchField.Margin = new System.Windows.Forms.Padding(2);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(159, 20);
            this.searchField.TabIndex = 3;
            // 
            // searchBut
            // 
            this.searchBut.Image = ((System.Drawing.Image) (resources.GetObject("searchBut.Image")));
            this.searchBut.Location = new System.Drawing.Point(430, 32);
            this.searchBut.Margin = new System.Windows.Forms.Padding(2);
            this.searchBut.Name = "searchBut";
            this.searchBut.Size = new System.Drawing.Size(32, 26);
            this.searchBut.TabIndex = 4;
            this.searchBut.UseVisualStyleBackColor = true;
            this.searchBut.Click += new System.EventHandler(this.searchBut_Click);
            // 
            // idxLabel
            // 
            this.idxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.idxLabel.Location = new System.Drawing.Point(49, 343);
            this.idxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idxLabel.Name = "idxLabel";
            this.idxLabel.Size = new System.Drawing.Size(49, 20);
            this.idxLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(102, 343);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "de 10000";
            // 
            // clearBut
            // 
            this.clearBut.Location = new System.Drawing.Point(482, 32);
            this.clearBut.Margin = new System.Windows.Forms.Padding(2);
            this.clearBut.Name = "clearBut";
            this.clearBut.Size = new System.Drawing.Size(75, 26);
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
            this.histogramGraph.Location = new System.Drawing.Point(256, 80);
            this.histogramGraph.Name = "histogramGraph";
            this.histogramGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.histogramGraph.PaletteCustomColors = new System.Drawing.Color[] {System.Drawing.Color.Black};
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.histogramGraph.Series.Add(series1);
            this.histogramGraph.Size = new System.Drawing.Size(493, 274);
            this.histogramGraph.TabIndex = 8;
            this.histogramGraph.Text = "chart1";
            // 
            // ExploreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(761, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExploreWindow";
            ((System.ComponentModel.ISupportInitialize) (this.NumberImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.histogramGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

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