using System;
using System.Drawing;
using System.Windows.Forms;
using handwritten_number_classifier.Model;

namespace handwritten_number_classifier.ui
{
    public partial class Form1 : Form
    {
        
        private Controller c;
        public Form1()
        {
            InitializeComponent();
            MaximizeBox = false;
            c = new Controller();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExploreWindow ew = new ExploreWindow(this.c);
            ew.ShowDialog();
        }

        private void neuralNBut_Click(object sender, EventArgs e)
        {
            SetButtons(false);
            c.LoadTensorflow();
            NeuralNetworkWindow nnw = new NeuralNetworkWindow(this.c);
            nnw.ShowDialog();
            SetButtons(true);
        }

        private void SetButtons(bool isEnabled)
        {
            neuralNBut.Enabled = isEnabled;
            exploreBut.Enabled = isEnabled;
        }

        private void neuralNBut_mouseIn(object sender, EventArgs e)
        {
            neuralNBut.Font = new Font(exploreBut.Font.FontFamily, exploreBut.Font.Size + 3);
        }
        private void neuralNbut_mouseOut(object sender, EventArgs e)
        {
            neuralNBut.Font = new Font(exploreBut.Font.FontFamily, exploreBut.Font.Size - 3);
        }
        private void button_mouseIn(object sender, EventArgs e)
        {
            exploreBut.Font = new Font(exploreBut.Font.FontFamily, exploreBut.Font.Size + 3);
        }
        private void button_mouseOut(object sender, EventArgs e)
        {
            exploreBut.Font = new Font(exploreBut.Font.FontFamily, exploreBut.Font.Size - 3);
        }
    }
}