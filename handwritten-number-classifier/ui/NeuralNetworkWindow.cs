using System;
using System.Windows.Forms;
using handwritten_number_classifier.Model;
using NumSharp;

namespace handwritten_number_classifier.ui
{
    public partial class NeuralNetworkWindow : Form
    {

        private Controller c;
        private int idx = 0;
        
        public NeuralNetworkWindow(Controller c)
        {
            InitializeComponent();
            MaximizeBox = false;
            this.c = c;
            UpdateGraphics(idx);
            CheckIdx();
            probsChart.Legends.Clear();
        }

        private void UpdateGraphics(int index)
        {
            NumberImages.Image = c.GetImageWithIndex(index , 280);
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
            NDArray results = c.MakePredictions(idx);
            UpdateLabels(results);
            UpdateChart(results);
        }

        private void UpdateLabels(NDArray results)
        {
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
            
            
            //Fill
            for (int i = 0; i < 10; i++)
            {
                probsChart.Series[0].Points.AddXY(i, results[i][0]*100);
            }
        }


    }
}