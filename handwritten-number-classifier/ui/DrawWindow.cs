using System;
using System.Drawing;
using System.Windows.Forms;
using handwritten_number_classifier.Model;

namespace handwritten_number_classifier.ui
{
    public partial class DrawWindow : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black, 3);
        public Graphics g;
        public Controller c;
        
        public DrawWindow(Controller c)
        {
            InitializeComponent();
            g = panel.CreateGraphics();
            this.c = c;
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(p,old,current);
                old = current;
            }
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            panel.Invalidate();
        }
    }
}