using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using handwritten_number_classifier.Model;
using NumSharp;

namespace handwritten_number_classifier.ui
{
    public partial class NeuralNetworkWindow : Form
    {

        private Controller c;
        private int idx = 0;
        private List<Label> _predLabels;
        
        public NeuralNetworkWindow(Controller c)
        {
            InitializeComponent();
            MaximizeBox = false;
            this.c = c;
            UpdateGraphics(idx);
            CheckIdx();
            probsChart.Legends.Clear();
            _predLabels = new List<Label>();
            ListifyLabels();

            
        }

        private void ListifyLabels()
        {
            _predLabels.Add(fl1);
            _predLabels.Add(fl2);
            _predLabels.Add(fl3);
            _predLabels.Add(fl4);
            _predLabels.Add(fl5);
            _predLabels.Add(fl6);
            _predLabels.Add(fl7);
            _predLabels.Add(fl8);
            
            _predLabels.Add(ll1);
            _predLabels.Add(ll2);
            _predLabels.Add(ll3);
            _predLabels.Add(ll4);
            _predLabels.Add(ll5);
            _predLabels.Add(ll6);
            _predLabels.Add(ll7);
            _predLabels.Add(ll8);
            _predLabels.Add(ll9);
            _predLabels.Add(ll10);
        }
        
        private void UpdateGraphics(int index)
        {
            NumberImages.Image = c.GetImageWithIndex(index , 280);
        }

        public void UpdateGraphWithImg(Bitmap img)
        {
            NumberImages.Image = img;
            Bitmap newImg = new Bitmap(img, new Size(28, 28));
            
            NDArray d =  newImg.ToNDArray()["0,:,:,3"];
            
            NDArray results = c.MakePrediction(d)[1];
            UpdateChart(results);
            UpdateLabels(results);
            UpdateNodes(c.MakePrediction(d)[0], results);
            testBut.Enabled = false;
            nextBut.Enabled = false;
            prevBut.Enabled = false;
            TFCheck.Checked = false;
            OwnImpleCheck.Checked = false;
        }

        private void CheckIdx()
        {
            if (idx == 0)
            {
                prevBut.Enabled = false;
            }
            if (idx > 0)
            {
                prevBut.Enabled = true;
            }
            if (idx == 9999)
            {
                nextBut.Enabled = false;
            }
            if (idx < 9999)
            {
                nextBut.Enabled = true;
            }
        }


        private void prevBut_Click(object sender, EventArgs e)
        {
            idx--;
            CheckIdx();
            UpdateGraphics(idx);
        }

        private void nextBut_Click(object sender, EventArgs e)
        {
            idx++;
            CheckIdx();
            UpdateGraphics(idx);
        }


        private void testBut_Click(object sender, EventArgs e)
        {
            NDArray results = null;
            if (OwnImpleCheck.Checked)
            {
                results = c.MakePrediction(idx)[1];
                UpdateNodes(c.MakePrediction(idx)[0], results);
            }
            else if (TFCheck.Checked)
            {
                results = c.MakePredictionTf(idx);
                UpdateNodesTF();
            }

            try
            {
                UpdateLabels(results);
                UpdateChart(results);
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a checkbox", "Error!", MessageBoxButtons.OK);
            }
            
        }

        private void UpdateLabels(NDArray results)
        {
            results = results.reshape(10, 1);
            prob0.Text = ((double)(results[0][0]*100)).ToString("#.##") + "%";
            prob1.Text = ((double)(results[1][0]*100)).ToString("#.##") + "%";
            prob2.Text = ((double)(results[2][0]*100)).ToString("#.##") + "%";
            prob3.Text = ((double)(results[3][0]*100)).ToString("#.##") + "%";
            prob4.Text = ((double)(results[4][0]*100)).ToString("#.##") + "%";
            prob5.Text = ((double)(results[5][0]*100)).ToString("#.##") + "%";
            prob6.Text = ((double)(results[6][0]*100)).ToString("#.##") + "%";
            prob7.Text = ((double)(results[7][0]*100)).ToString("#.##") + "%";
            prob8.Text = ((double)(results[8][0]*100)).ToString("#.##") + "%";
            prob9.Text = ((double)(results[9][0]*100)).ToString("#.##") + "%";
            
        }

        private void UpdateChart(NDArray results)
        {
            results = results.reshape(10, 1);
            probsChart.Series[0].Points.Clear();
            
            //Fill
            for (int i = 0; i < 10; i++)
            {
                probsChart.Series[0].Points.AddXY(i, results[i][0]*100);
            }
        }


        private void DrawBut_Click(object sender, EventArgs e)
        {
            DrawWindow dw = new DrawWindow(this.c, this);
            dw.ShowDialog();
        }

        private void ClearDrawBut_Click(object sender, EventArgs e)
        {
            UpdateGraphics(idx);
            CheckIdx();
            testBut.Enabled = true;
        }

        private void OwnImpleCheck_Click(object sender, EventArgs e)
        {
            TFCheck.Checked = false;
        }

        private void TFCheck_Click(object sender, EventArgs e)
        {
            OwnImpleCheck.Checked = false;
        }

        private void UpdateNodes(NDArray results1, NDArray results2)
        {
            for (int i = 0; i < 8; i++)
            {
                _predLabels[i].Text = ((double)(results1[i][0])).ToString("#.####");
            }
            
            var col = Color.Chartreuse;
            
            for (int i = 8; i < 18; i++)
            {
                var a = (double) results2[i-8][0];
                _predLabels[i].Text = (a).ToString("#.####");

                if (_predLabels[i].Text == "")
                    _predLabels[i].Text = "0";
                
                if (a > 0.05)
                    _predLabels[i].BackColor = Color.FromArgb((int)(a*255), col);
                else
                    _predLabels[i].BackColor = Color.FromArgb(10, col);
            }
        }
        
        private void UpdateNodesTF()
        {
            for (int i = 0; i < 8; i++)
            {
                _predLabels[i].Text = "";
            }

            for (int i = 8; i < 18; i++)
            {
                _predLabels[i].Text = "";
                _predLabels[i].ResetBackColor();
            }
            
            
        }
    }
}