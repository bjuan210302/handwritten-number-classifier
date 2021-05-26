using System;
using System.Drawing;
using System.Windows.Forms;
using handwritten_number_classifier.Model;
using NumSharp;

namespace handwritten_number_classifier.ui
{
    public partial class ExploreWindow : Form
    {
        private Controller c;
        private int idx = 0;
        private int idxEsp = 0;
        private NDArray indexes;
        private double indexS;
        private bool searchMode;
        public ExploreWindow(Controller c)
        {
            InitializeComponent();
            MaximizeBox = false;
            this.c = c;
            NumberImage.Dock = DockStyle.Fill;
            
            //Chart 
            histogramGraph.ChartAreas[0].AxisX.Maximum = 255;
            histogramGraph.ChartAreas[0].AxisX.Minimum = 0;
            histogramGraph.ChartAreas[0].AxisX.Interval = 17;
            histogramGraph.Series[0]["PixelPointWidth"] = "5";
            
            histogramGraph.ChartAreas[0].AxisY.Maximum = 10;
            histogramGraph.ChartAreas[0].AxisY.Minimum = 0;
            
            histogramGraph.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Coral;
            histogramGraph.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            
            UpdateGraphics(idx);
            searchMode = false;
            checkIdx();
            actualizeLabel();
            
        }

        private void UpdateGraphics(int imageIndex)
        {
            NumberImage.Image = c.GetImageWithIndex(imageIndex , 280);
            var points = c.GetHistogramOf(imageIndex);

            histogramGraph.Series[0].Points.Clear();
            
            for (int i = 0; i < points.shape[0]; i++)
            {
                histogramGraph.Series[0].Points.AddXY(points[i,0], points[i, 1]);
            }
        }
        
        private void searchBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(searchField.Text) < 0 || int.Parse(searchField.Text) > 9)
                {
                    MessageBox.Show("The number must be between 0 and 9!", "Error!", MessageBoxButtons.OK);
                    searchField.Text = "";
                }
                else
                {
                    searchMode = true;
                    indexes = c.GetAllIndexesWithLabel(int.Parse(searchField.Text));
                    idxEsp = 0;
                    indexS = indexes[idxEsp];
                    UpdateGraphics((int) indexS);
                    actualizeLabel();
                    checkIdx();
                    searchField.Text = "";
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Format", "Error!", MessageBoxButtons.OK);
                searchField.Text = "";
            }
            
        }

        private void nextBut_Click(object sender, EventArgs e)
        {
            if (!searchMode)
            {
                idx++;
                checkIdx();
                actualizeLabel();
                UpdateGraphics(idx);
            }
            else
            {
                idxEsp++;
                indexS = indexes[idxEsp];
                checkIdx();
                actualizeLabel();
                UpdateGraphics((int)indexS);
            }

        }

        private void prevBut_Click(object sender, EventArgs e)
        {
            if (!searchMode)
            {
                idx--;
                checkIdx();
                actualizeLabel();
                UpdateGraphics(idx);
            }
            else
            {
                idxEsp--;
                indexS = indexes[idxEsp];
                checkIdx();
                actualizeLabel();
                UpdateGraphics((int)indexS);
            }
            
        }

        private void checkIdx()
        {
            if (!searchMode)
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
            else
            {
                if (idxEsp == 0)
                {
                    prevBut.Enabled = false;
                }
                if (idxEsp > 0)
                {
                    prevBut.Enabled = true;
                }
                if (idx == indexes.size)
                {
                    nextBut.Enabled = false;
                }
                if (idx < indexes.size)
                {
                    nextBut.Enabled = true;
                }
            }
            
        }

        private void actualizeLabel()
        {
            if (searchMode)
            {
                idxLabel.Text = (indexS + 1) + "";
            }
            else
            {
                idxLabel.Text = (idx + 1) + "" ;
            }
        }


        private void clearBut_Click(object sender, EventArgs e)
        {
            searchMode = false;
            idx = 0;
            UpdateGraphics(idx);
            checkIdx();
            actualizeLabel();
            searchField.Text = "";
        }

        private void viewChartsBut_Click(object sender, EventArgs e)
        {
            ChartsWindow cw = new ChartsWindow(this.c);
            cw.ShowDialog();
        }
    }
}