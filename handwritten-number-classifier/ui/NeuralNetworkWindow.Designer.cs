using System.ComponentModel;

namespace handwritten_number_classifier.ui
{
    partial class NeuralNetworkWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuralNetworkWindow));
            this.Train = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.iterNumbBox = new System.Windows.Forms.TextBox();
            this.trainBut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberImages = new System.Windows.Forms.PictureBox();
            this.prevBut = new System.Windows.Forms.Button();
            this.nextBut = new System.Windows.Forms.Button();
            this.testBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.prob0 = new System.Windows.Forms.Label();
            this.prob9 = new System.Windows.Forms.Label();
            this.prob8 = new System.Windows.Forms.Label();
            this.prob7 = new System.Windows.Forms.Label();
            this.prob6 = new System.Windows.Forms.Label();
            this.prob5 = new System.Windows.Forms.Label();
            this.prob4 = new System.Windows.Forms.Label();
            this.prob3 = new System.Windows.Forms.Label();
            this.prob2 = new System.Windows.Forms.Label();
            this.prob1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumberImages)).BeginInit();
            this.SuspendLayout();
            // 
            // Train
            // 
            this.Train.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Train.Location = new System.Drawing.Point(106, 27);
            this.Train.Name = "Train";
            this.Train.Size = new System.Drawing.Size(310, 79);
            this.Train.TabIndex = 0;
            this.Train.Text = "Train";
            this.Train.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 109);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(282, 263);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(335, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cost:";
            // 
            // costLbl
            // 
            this.costLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.costLbl.Location = new System.Drawing.Point(391, 131);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(65, 37);
            this.costLbl.TabIndex = 4;
            this.costLbl.Text = "0";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(777, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 79);
            this.label1.TabIndex = 5;
            this.label1.Text = "Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(30, 454);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 83);
            this.label4.TabIndex = 8;
            this.label4.Text = "How many images do you want to train with?";
            // 
            // iterNumbBox
            // 
            this.iterNumbBox.Location = new System.Drawing.Point(212, 478);
            this.iterNumbBox.Name = "iterNumbBox";
            this.iterNumbBox.Size = new System.Drawing.Size(120, 22);
            this.iterNumbBox.TabIndex = 9;
            // 
            // trainBut
            // 
            this.trainBut.Location = new System.Drawing.Point(352, 462);
            this.trainBut.Name = "trainBut";
            this.trainBut.Size = new System.Drawing.Size(104, 54);
            this.trainBut.TabIndex = 10;
            this.trainBut.Text = "Train";
            this.trainBut.UseVisualStyleBackColor = true;
            this.trainBut.Click += new System.EventHandler(this.trainBut_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(212, 503);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "0<x<60000";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberImages
            // 
            this.NumberImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberImages.Location = new System.Drawing.Point(641, 109);
            this.NumberImages.Name = "NumberImages";
            this.NumberImages.Size = new System.Drawing.Size(300, 300);
            this.NumberImages.TabIndex = 12;
            this.NumberImages.TabStop = false;
            // 
            // prevBut
            // 
            this.prevBut.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("prevBut.BackgroundImage")));
            this.prevBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.prevBut.Location = new System.Drawing.Point(705, 416);
            this.prevBut.Name = "prevBut";
            this.prevBut.Size = new System.Drawing.Size(45, 52);
            this.prevBut.TabIndex = 13;
            this.prevBut.UseVisualStyleBackColor = true;
            this.prevBut.Click += new System.EventHandler(this.prevBut_Click);
            // 
            // nextBut
            // 
            this.nextBut.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("nextBut.BackgroundImage")));
            this.nextBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.nextBut.Location = new System.Drawing.Point(852, 416);
            this.nextBut.Name = "nextBut";
            this.nextBut.Size = new System.Drawing.Size(45, 52);
            this.nextBut.TabIndex = 14;
            this.nextBut.UseVisualStyleBackColor = true;
            this.nextBut.Click += new System.EventHandler(this.nextBut_Click);
            // 
            // testBut
            // 
            this.testBut.Location = new System.Drawing.Point(755, 487);
            this.testBut.Name = "testBut";
            this.testBut.Size = new System.Drawing.Size(97, 49);
            this.testBut.TabIndex = 15;
            this.testBut.Text = "Test";
            this.testBut.UseVisualStyleBackColor = true;
            this.testBut.Click += new System.EventHandler(this.testBut_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(958, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Probabilities:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(984, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "0:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(984, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "8:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(984, 376);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "7:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(984, 440);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "9:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.Location = new System.Drawing.Point(984, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "6:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.Location = new System.Drawing.Point(984, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "5:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.Location = new System.Drawing.Point(984, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "4:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.Location = new System.Drawing.Point(984, 243);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "3:";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label15.Location = new System.Drawing.Point(984, 211);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "2:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label16.Location = new System.Drawing.Point(984, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "1:";
            // 
            // prob0
            // 
            this.prob0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob0.Location = new System.Drawing.Point(1021, 147);
            this.prob0.Name = "prob0";
            this.prob0.Size = new System.Drawing.Size(98, 16);
            this.prob0.TabIndex = 27;
            this.prob0.Text = "0%";
            // 
            // prob9
            // 
            this.prob9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob9.Location = new System.Drawing.Point(1021, 440);
            this.prob9.Name = "prob9";
            this.prob9.Size = new System.Drawing.Size(98, 16);
            this.prob9.TabIndex = 28;
            this.prob9.Text = "0%";
            // 
            // prob8
            // 
            this.prob8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob8.Location = new System.Drawing.Point(1021, 407);
            this.prob8.Name = "prob8";
            this.prob8.Size = new System.Drawing.Size(98, 16);
            this.prob8.TabIndex = 29;
            this.prob8.Text = "0%";
            // 
            // prob7
            // 
            this.prob7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob7.Location = new System.Drawing.Point(1021, 376);
            this.prob7.Name = "prob7";
            this.prob7.Size = new System.Drawing.Size(98, 16);
            this.prob7.TabIndex = 30;
            this.prob7.Text = "0%";
            // 
            // prob6
            // 
            this.prob6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob6.Location = new System.Drawing.Point(1021, 347);
            this.prob6.Name = "prob6";
            this.prob6.Size = new System.Drawing.Size(98, 16);
            this.prob6.TabIndex = 31;
            this.prob6.Text = "0%";
            // 
            // prob5
            // 
            this.prob5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob5.Location = new System.Drawing.Point(1021, 313);
            this.prob5.Name = "prob5";
            this.prob5.Size = new System.Drawing.Size(98, 16);
            this.prob5.TabIndex = 32;
            this.prob5.Text = "0%";
            // 
            // prob4
            // 
            this.prob4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob4.Location = new System.Drawing.Point(1021, 279);
            this.prob4.Name = "prob4";
            this.prob4.Size = new System.Drawing.Size(98, 16);
            this.prob4.TabIndex = 33;
            this.prob4.Text = "0%";
            // 
            // prob3
            // 
            this.prob3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob3.Location = new System.Drawing.Point(1021, 243);
            this.prob3.Name = "prob3";
            this.prob3.Size = new System.Drawing.Size(98, 16);
            this.prob3.TabIndex = 34;
            this.prob3.Text = "0%";
            // 
            // prob2
            // 
            this.prob2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob2.Location = new System.Drawing.Point(1021, 211);
            this.prob2.Name = "prob2";
            this.prob2.Size = new System.Drawing.Size(98, 16);
            this.prob2.TabIndex = 35;
            this.prob2.Text = "0%";
            // 
            // prob1
            // 
            this.prob1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob1.Location = new System.Drawing.Point(1021, 177);
            this.prob1.Name = "prob1";
            this.prob1.Size = new System.Drawing.Size(98, 16);
            this.prob1.TabIndex = 36;
            this.prob1.Text = "0%";
            // 
            // NeuralNetworkWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 644);
            this.Controls.Add(this.prob1);
            this.Controls.Add(this.prob2);
            this.Controls.Add(this.prob3);
            this.Controls.Add(this.prob4);
            this.Controls.Add(this.prob5);
            this.Controls.Add(this.prob6);
            this.Controls.Add(this.prob7);
            this.Controls.Add(this.prob8);
            this.Controls.Add(this.prob9);
            this.Controls.Add(this.prob0);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.testBut);
            this.Controls.Add(this.nextBut);
            this.Controls.Add(this.prevBut);
            this.Controls.Add(this.NumberImages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trainBut);
            this.Controls.Add(this.iterNumbBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.Train);
            this.Name = "NeuralNetworkWindow";
            this.Text = "NeuralNetworkWindow";
            ((System.ComponentModel.ISupportInitialize) (this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.NumberImages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label prob1;
        private System.Windows.Forms.Label prob2;
        private System.Windows.Forms.Label prob3;
        private System.Windows.Forms.Label prob4;
        private System.Windows.Forms.Label prob5;
        private System.Windows.Forms.Label prob6;
        private System.Windows.Forms.Label prob7;
        private System.Windows.Forms.Label prob8;
        private System.Windows.Forms.Label prob9;

        private System.Windows.Forms.Label prob0;

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button testBut;

        private System.Windows.Forms.Button nextBut;

        private System.Windows.Forms.Button prevBut;

        private System.Windows.Forms.PictureBox NumberImages;

        private System.Windows.Forms.TextBox iterNumbBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button trainBut;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label costLbl;

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label Train;

        #endregion
    }
}