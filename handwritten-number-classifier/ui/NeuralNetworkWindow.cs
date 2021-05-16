using System;
using System.Windows.Forms;
using handwritten_number_classifier.Model;

namespace handwritten_number_classifier.ui
{
    public partial class NeuralNetworkWindow : Form
    {

        private Controller c;
        public NeuralNetworkWindow(Controller c)
        {
            InitializeComponent();
            this.c = c;
        }

        
    }
}