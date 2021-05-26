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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeuralNetworkWindow));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
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
            this.probsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OwnImpleCheck = new System.Windows.Forms.CheckBox();
            this.TFCheck = new System.Windows.Forms.CheckBox();
            this.DrawBut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.ll10 = new System.Windows.Forms.Label();
            this.ll9 = new System.Windows.Forms.Label();
            this.ll8 = new System.Windows.Forms.Label();
            this.ll7 = new System.Windows.Forms.Label();
            this.ll6 = new System.Windows.Forms.Label();
            this.ll5 = new System.Windows.Forms.Label();
            this.ll4 = new System.Windows.Forms.Label();
            this.ll3 = new System.Windows.Forms.Label();
            this.ll2 = new System.Windows.Forms.Label();
            this.ll1 = new System.Windows.Forms.Label();
            this.fl8 = new System.Windows.Forms.Label();
            this.fl7 = new System.Windows.Forms.Label();
            this.fl6 = new System.Windows.Forms.Label();
            this.fl5 = new System.Windows.Forms.Label();
            this.fl4 = new System.Windows.Forms.Label();
            this.fl3 = new System.Windows.Forms.Label();
            this.fl2 = new System.Windows.Forms.Label();
            this.fl1 = new System.Windows.Forms.Label();
            this.ClearDrawBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.NumberImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.probsChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(2, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 57);
            this.label1.TabIndex = 5;
            this.label1.Text = "Test";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NumberImages
            // 
            this.NumberImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumberImages.Location = new System.Drawing.Point(12, 259);
            this.NumberImages.Name = "NumberImages";
            this.NumberImages.Size = new System.Drawing.Size(300, 300);
            this.NumberImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.NumberImages.TabIndex = 12;
            this.NumberImages.TabStop = false;
            // 
            // prevBut
            // 
            this.prevBut.BackgroundImage = ((System.Drawing.Image) (resources.GetObject("prevBut.BackgroundImage")));
            this.prevBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.prevBut.Location = new System.Drawing.Point(51, 572);
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
            this.nextBut.Location = new System.Drawing.Point(205, 572);
            this.nextBut.Name = "nextBut";
            this.nextBut.Size = new System.Drawing.Size(45, 52);
            this.nextBut.TabIndex = 14;
            this.nextBut.UseVisualStyleBackColor = true;
            this.nextBut.Click += new System.EventHandler(this.nextBut_Click);
            // 
            // testBut
            // 
            this.testBut.Location = new System.Drawing.Point(102, 572);
            this.testBut.Name = "testBut";
            this.testBut.Size = new System.Drawing.Size(97, 52);
            this.testBut.TabIndex = 15;
            this.testBut.Text = "Test";
            this.testBut.UseVisualStyleBackColor = true;
            this.testBut.Click += new System.EventHandler(this.testBut_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(941, 491);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 16;
            this.label6.Text = "Results:";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(956, 525);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "0:";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(956, 785);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "8:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(956, 754);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "7:";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(956, 818);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "9:";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.Location = new System.Drawing.Point(956, 725);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "6:";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.Location = new System.Drawing.Point(956, 691);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "5:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.Location = new System.Drawing.Point(956, 657);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "4:";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.Location = new System.Drawing.Point(956, 621);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "3:";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label15.Location = new System.Drawing.Point(956, 589);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "2:";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label16.Location = new System.Drawing.Point(956, 555);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "1:";
            // 
            // prob0
            // 
            this.prob0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob0.Location = new System.Drawing.Point(993, 525);
            this.prob0.Name = "prob0";
            this.prob0.Size = new System.Drawing.Size(98, 16);
            this.prob0.TabIndex = 27;
            this.prob0.Text = "0%";
            // 
            // prob9
            // 
            this.prob9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob9.Location = new System.Drawing.Point(993, 818);
            this.prob9.Name = "prob9";
            this.prob9.Size = new System.Drawing.Size(98, 16);
            this.prob9.TabIndex = 28;
            this.prob9.Text = "0%";
            // 
            // prob8
            // 
            this.prob8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob8.Location = new System.Drawing.Point(993, 785);
            this.prob8.Name = "prob8";
            this.prob8.Size = new System.Drawing.Size(98, 16);
            this.prob8.TabIndex = 29;
            this.prob8.Text = "0%";
            // 
            // prob7
            // 
            this.prob7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob7.Location = new System.Drawing.Point(993, 754);
            this.prob7.Name = "prob7";
            this.prob7.Size = new System.Drawing.Size(98, 16);
            this.prob7.TabIndex = 30;
            this.prob7.Text = "0%";
            // 
            // prob6
            // 
            this.prob6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob6.Location = new System.Drawing.Point(993, 725);
            this.prob6.Name = "prob6";
            this.prob6.Size = new System.Drawing.Size(98, 16);
            this.prob6.TabIndex = 31;
            this.prob6.Text = "0%";
            // 
            // prob5
            // 
            this.prob5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob5.Location = new System.Drawing.Point(993, 691);
            this.prob5.Name = "prob5";
            this.prob5.Size = new System.Drawing.Size(98, 16);
            this.prob5.TabIndex = 32;
            this.prob5.Text = "0%";
            // 
            // prob4
            // 
            this.prob4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob4.Location = new System.Drawing.Point(993, 657);
            this.prob4.Name = "prob4";
            this.prob4.Size = new System.Drawing.Size(98, 16);
            this.prob4.TabIndex = 33;
            this.prob4.Text = "0%";
            // 
            // prob3
            // 
            this.prob3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob3.Location = new System.Drawing.Point(993, 621);
            this.prob3.Name = "prob3";
            this.prob3.Size = new System.Drawing.Size(98, 16);
            this.prob3.TabIndex = 34;
            this.prob3.Text = "0%";
            // 
            // prob2
            // 
            this.prob2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob2.Location = new System.Drawing.Point(993, 589);
            this.prob2.Name = "prob2";
            this.prob2.Size = new System.Drawing.Size(98, 16);
            this.prob2.TabIndex = 35;
            this.prob2.Text = "0%";
            // 
            // prob1
            // 
            this.prob1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.prob1.Location = new System.Drawing.Point(993, 555);
            this.prob1.Name = "prob1";
            this.prob1.Size = new System.Drawing.Size(98, 16);
            this.prob1.TabIndex = 36;
            this.prob1.Text = "0%";
            // 
            // probsChart
            // 
            chartArea1.Name = "ChartArea1";
            this.probsChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.probsChart.Legends.Add(legend1);
            this.probsChart.Location = new System.Drawing.Point(438, 481);
            this.probsChart.Name = "probsChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.probsChart.Series.Add(series1);
            this.probsChart.Size = new System.Drawing.Size(421, 363);
            this.probsChart.TabIndex = 37;
            this.probsChart.Text = "chart1";
            // 
            // OwnImpleCheck
            // 
            this.OwnImpleCheck.Location = new System.Drawing.Point(32, 210);
            this.OwnImpleCheck.Name = "OwnImpleCheck";
            this.OwnImpleCheck.Size = new System.Drawing.Size(120, 38);
            this.OwnImpleCheck.TabIndex = 38;
            this.OwnImpleCheck.Text = "Own implementation";
            this.OwnImpleCheck.UseVisualStyleBackColor = true;
            this.OwnImpleCheck.Click += new System.EventHandler(this.OwnImpleCheck_Click);
            // 
            // TFCheck
            // 
            this.TFCheck.Location = new System.Drawing.Point(173, 215);
            this.TFCheck.Name = "TFCheck";
            this.TFCheck.Size = new System.Drawing.Size(120, 28);
            this.TFCheck.TabIndex = 39;
            this.TFCheck.Text = "TensorFlow";
            this.TFCheck.UseVisualStyleBackColor = true;
            this.TFCheck.Click += new System.EventHandler(this.TFCheck_Click);
            // 
            // DrawBut
            // 
            this.DrawBut.Location = new System.Drawing.Point(51, 645);
            this.DrawBut.Name = "DrawBut";
            this.DrawBut.Size = new System.Drawing.Size(91, 75);
            this.DrawBut.TabIndex = 40;
            this.DrawBut.Text = "Draw";
            this.DrawBut.UseVisualStyleBackColor = true;
            this.DrawBut.Click += new System.EventHandler(this.DrawBut_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.ll10);
            this.panel1.Controls.Add(this.ll9);
            this.panel1.Controls.Add(this.ll8);
            this.panel1.Controls.Add(this.ll7);
            this.panel1.Controls.Add(this.ll6);
            this.panel1.Controls.Add(this.ll5);
            this.panel1.Controls.Add(this.ll4);
            this.panel1.Controls.Add(this.ll3);
            this.panel1.Controls.Add(this.ll2);
            this.panel1.Controls.Add(this.ll1);
            this.panel1.Controls.Add(this.fl8);
            this.panel1.Controls.Add(this.fl7);
            this.panel1.Controls.Add(this.fl6);
            this.panel1.Controls.Add(this.fl5);
            this.panel1.Controls.Add(this.fl4);
            this.panel1.Controls.Add(this.fl3);
            this.panel1.Controls.Add(this.fl2);
            this.panel1.Controls.Add(this.fl1);
            this.panel1.Location = new System.Drawing.Point(411, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 430);
            this.panel1.TabIndex = 41;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label32.Location = new System.Drawing.Point(381, 161);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(80, 48);
            this.label32.TabIndex = 19;
            this.label32.Text = "Final Layer";
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label31.Location = new System.Drawing.Point(65, 161);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(90, 74);
            this.label31.TabIndex = 18;
            this.label31.Text = "First Layer";
            // 
            // ll10
            // 
            this.ll10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ll10.Location = new System.Drawing.Point(510, 350);
            this.ll10.Name = "ll10";
            this.ll10.Size = new System.Drawing.Size(65, 29);
            this.ll10.TabIndex = 17;
            this.ll10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ll9
            // 
            this.ll9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ll9.Location = new System.Drawing.Point(510, 314);
            this.ll9.Name = "ll9";
            this.ll9.Size = new System.Drawing.Size(65, 29);
            this.ll9.TabIndex = 16;
            this.ll9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ll8
            // 
            this.ll8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ll8.Location = new System.Drawing.Point(510, 278);
            this.ll8.Name = "ll8";
            this.ll8.Size = new System.Drawing.Size(65, 29);
            this.ll8.TabIndex = 15;
            this.ll8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ll7
            // 
            this.ll7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ll7.Location = new System.Drawing.Point(510, 242);
            this.ll7.Name = "ll7";
            this.ll7.Size = new System.Drawing.Size(65, 29);
            this.ll7.TabIndex = 14;
            this.ll7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ll6
            // 
            this.ll6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ll6.Location = new System.Drawing.Point(510, 206);
            this.ll6.Name = "ll6";
            this.ll6.Size = new System.Drawing.Size(65, 29);
            this.ll6.TabIndex = 13;
            this.ll6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ll5
            // 
            this.ll5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ll5.Location = new System.Drawing.Point(510, 170);
            this.ll5.Name = "ll5";
            this.ll5.Size = new System.Drawing.Size(65, 29);
            this.ll5.TabIndex = 12;
            this.ll5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ll4
            // 
            this.ll4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ll4.Location = new System.Drawing.Point(510, 134);
            this.ll4.Name = "ll4";
            this.ll4.Size = new System.Drawing.Size(65, 29);
            this.ll4.TabIndex = 11;
            this.ll4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ll3
            // 
            this.ll3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ll3.Location = new System.Drawing.Point(510, 98);
            this.ll3.Name = "ll3";
            this.ll3.Size = new System.Drawing.Size(65, 29);
            this.ll3.TabIndex = 10;
            this.ll3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ll2
            // 
            this.ll2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ll2.Location = new System.Drawing.Point(510, 62);
            this.ll2.Name = "ll2";
            this.ll2.Size = new System.Drawing.Size(65, 29);
            this.ll2.TabIndex = 9;
            this.ll2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ll1
            // 
            this.ll1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ll1.Location = new System.Drawing.Point(510, 26);
            this.ll1.Name = "ll1";
            this.ll1.Size = new System.Drawing.Size(65, 29);
            this.ll1.TabIndex = 8;
            this.ll1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fl8
            // 
            this.fl8.BackColor = System.Drawing.SystemColors.Control;
            this.fl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fl8.Location = new System.Drawing.Point(181, 342);
            this.fl8.Name = "fl8";
            this.fl8.Size = new System.Drawing.Size(54, 34);
            this.fl8.TabIndex = 7;
            this.fl8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fl7
            // 
            this.fl7.BackColor = System.Drawing.SystemColors.Control;
            this.fl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fl7.Location = new System.Drawing.Point(181, 298);
            this.fl7.Name = "fl7";
            this.fl7.Size = new System.Drawing.Size(54, 34);
            this.fl7.TabIndex = 6;
            this.fl7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fl6
            // 
            this.fl6.BackColor = System.Drawing.SystemColors.Control;
            this.fl6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fl6.Location = new System.Drawing.Point(181, 254);
            this.fl6.Name = "fl6";
            this.fl6.Size = new System.Drawing.Size(54, 34);
            this.fl6.TabIndex = 5;
            this.fl6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fl5
            // 
            this.fl5.BackColor = System.Drawing.SystemColors.Control;
            this.fl5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fl5.Location = new System.Drawing.Point(181, 210);
            this.fl5.Name = "fl5";
            this.fl5.Size = new System.Drawing.Size(54, 34);
            this.fl5.TabIndex = 4;
            this.fl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fl4
            // 
            this.fl4.BackColor = System.Drawing.SystemColors.Control;
            this.fl4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fl4.Location = new System.Drawing.Point(181, 166);
            this.fl4.Name = "fl4";
            this.fl4.Size = new System.Drawing.Size(54, 34);
            this.fl4.TabIndex = 3;
            this.fl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fl3
            // 
            this.fl3.BackColor = System.Drawing.SystemColors.Control;
            this.fl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fl3.Location = new System.Drawing.Point(181, 122);
            this.fl3.Name = "fl3";
            this.fl3.Size = new System.Drawing.Size(54, 34);
            this.fl3.TabIndex = 2;
            this.fl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fl2
            // 
            this.fl2.BackColor = System.Drawing.SystemColors.Control;
            this.fl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fl2.Location = new System.Drawing.Point(181, 78);
            this.fl2.Name = "fl2";
            this.fl2.Size = new System.Drawing.Size(54, 34);
            this.fl2.TabIndex = 1;
            this.fl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fl1
            // 
            this.fl1.BackColor = System.Drawing.SystemColors.Control;
            this.fl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fl1.Location = new System.Drawing.Point(181, 34);
            this.fl1.Name = "fl1";
            this.fl1.Size = new System.Drawing.Size(54, 34);
            this.fl1.TabIndex = 0;
            this.fl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ClearDrawBut
            // 
            this.ClearDrawBut.Location = new System.Drawing.Point(159, 645);
            this.ClearDrawBut.Name = "ClearDrawBut";
            this.ClearDrawBut.Size = new System.Drawing.Size(91, 75);
            this.ClearDrawBut.TabIndex = 42;
            this.ClearDrawBut.Text = "Clear Draw";
            this.ClearDrawBut.UseVisualStyleBackColor = true;
            this.ClearDrawBut.Click += new System.EventHandler(this.ClearDrawBut_Click);
            // 
            // NeuralNetworkWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 866);
            this.Controls.Add(this.ClearDrawBut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DrawBut);
            this.Controls.Add(this.TFCheck);
            this.Controls.Add(this.OwnImpleCheck);
            this.Controls.Add(this.probsChart);
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
            this.Controls.Add(this.label1);
            this.Name = "NeuralNetworkWindow";
            this.Text = "NeuralNetworkWindow";
            ((System.ComponentModel.ISupportInitialize) (this.NumberImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.probsChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label32;

        private System.Windows.Forms.Label label31;

        private System.Windows.Forms.Label ll2;
        private System.Windows.Forms.Label ll3;
        private System.Windows.Forms.Label ll4;
        private System.Windows.Forms.Label ll5;
        private System.Windows.Forms.Label ll6;
        private System.Windows.Forms.Label ll7;
        private System.Windows.Forms.Label ll8;
        private System.Windows.Forms.Label ll9;
        private System.Windows.Forms.Label ll10;

        private System.Windows.Forms.Label ll1;

        private System.Windows.Forms.Label fl8;

        private System.Windows.Forms.Label fl5;
        private System.Windows.Forms.Label fl6;
        private System.Windows.Forms.Label fl7;
        private System.Windows.Forms.Label fl2;
        private System.Windows.Forms.Label fl3;
        private System.Windows.Forms.Label fl4;

        private System.Windows.Forms.Button ClearDrawBut;

        private System.Windows.Forms.Label fl1;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Button DrawBut;

        private System.Windows.Forms.CheckBox OwnImpleCheck;
        private System.Windows.Forms.CheckBox TFCheck;

        private System.Windows.Forms.DataVisualization.Charting.Chart probsChart;

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

        private System.Windows.Forms.Label label1;

        #endregion
    }
}