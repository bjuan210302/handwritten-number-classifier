using System.Windows.Forms;
using handwritten_number_classifier.Model;

namespace handwritten_number_classifier.ui
{
    public partial class ChartsWindow : Form
    {
        private Controller c;
        public ChartsWindow(Controller c)
        {
            MaximizeBox = false;
            InitializeComponent();
            this.c = c;
        }
    }
}