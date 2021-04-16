using System;
using System.Drawing;
using System.Windows.Forms;
using handwritten_number_classifier.Model;

namespace handwritten_number_classifier.ui
{
    public partial class ExploreWindow : Form
    {
        private Controller c;
        private int idx = 0;
        public ExploreWindow()
        {
            InitializeComponent();
            MaximizeBox = false;
            c = new Controller();
            NumberImage.Dock = DockStyle.Fill;
            NumberImage.Image = c.GetImageWithIndex(idx, 280);
            checkIdx();
            actualizeLabel();
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            
        }

        private void nextBut_Click(object sender, EventArgs e)
        {
            idx++;
            checkIdx();
            actualizeLabel();
            NumberImage.Image = c.GetImageWithIndex(idx , 280);
            
        }

        private void prevBut_Click(object sender, EventArgs e)
        {
            idx--;
            checkIdx();
            actualizeLabel();
            NumberImage.Image = c.GetImageWithIndex(idx , 280);
        }

        private void checkIdx()
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

        private void actualizeLabel()
        {
            idxLabel.Text = (idx + 1) + "" ;
        }


    }
}