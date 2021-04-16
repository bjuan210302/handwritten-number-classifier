using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace handwritten_number_classifier.ui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            neuralNBut.Enabled = false;
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExploreWindow ew = new ExploreWindow();
            ew.ShowDialog();
        }
    }
}