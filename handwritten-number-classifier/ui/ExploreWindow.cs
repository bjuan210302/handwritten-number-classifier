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
        public ExploreWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
            c = new Controller();
            NumberImage.Dock = DockStyle.Fill;
            NumberImage.Image = c.GetImageWithIndex(idx, 280);
            searchMode = false;
            checkIdx();
            actualizeLabel();
            
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            searchMode = true;
            indexes = c.GetAllIndexesWithLabel(int.Parse(searchField.Text));
            idxEsp = 0;
            indexS = indexes[idxEsp];
            NumberImage.Image = c.GetImageWithIndex((int)indexS , 280);
            actualizeLabel();
            checkIdx();
        }

        private void nextBut_Click(object sender, EventArgs e)
        {
            if (!searchMode)
            {
                idx++;
                checkIdx();
                actualizeLabel();
                NumberImage.Image = c.GetImageWithIndex(idx , 280);
            }
            else
            {
                idxEsp++;
                indexS = indexes[idxEsp];
                checkIdx();
                actualizeLabel();
                NumberImage.Image = c.GetImageWithIndex((int)indexS , 280);
            }

            
            
        }

        private void prevBut_Click(object sender, EventArgs e)
        {
            if (!searchMode)
            {
                idx--;
                checkIdx();
                actualizeLabel();
                NumberImage.Image = c.GetImageWithIndex(idx , 280);
            }
            else
            {
                idxEsp--;
                indexS = indexes[idxEsp];
                checkIdx();
                actualizeLabel();
                NumberImage.Image = c.GetImageWithIndex((int)indexS , 280);
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
            NumberImage.Image = c.GetImageWithIndex(idx, 280);
            checkIdx();
            actualizeLabel();
            searchField.Text = "";
        }
    }
}