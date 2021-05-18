using System;
using System.Windows.Forms;
using handwritten_number_classifier.Model;

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
            //Here goes the method to test with a number
        }

        private void trainBut_Click(object sender, EventArgs e)
        {
            //Here goes the method to train the neural network
        }
    }
}