using System;
using System.Drawing;
using System.Windows.Forms;
using handwritten_number_classifier.Model;

namespace handwritten_number_classifier
{
    public partial class ExploreWindow : Form
    {
        private Controller c;
        private int idx = 0;
        public ExploreWindow()
        {
            InitializeComponent();
            c = new Controller();
            NumberImage.Dock = DockStyle.Fill;
            NumberImage.Image = c.GetImageWithIndex(idx, 280);
        }

        private void searchBut_Click(object sender, EventArgs e)
        {
            
        }

        private void nextBut_Click(object sender, EventArgs e)
        {
            idx++;
            NumberImage.Image = c.GetImageWithIndex(idx , 280);
        }

        private void prevBut_Click(object sender, EventArgs e)
        {
            idx--;
            NumberImage.Image = c.GetImageWithIndex(idx , 280);
        }

        
    }
}