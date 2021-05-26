using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using handwritten_number_classifier.Model;

namespace handwritten_number_classifier.ui
{
    public partial class DrawWindow : Form
    {
        public Point current;
        public Point old;
        public Pen p = new Pen(Color.Black,25 );
        public Graphics g;
        public Controller c;
        private Bitmap surface;
        private Graphics graph;
        private NeuralNetworkWindow nn;
        
        public DrawWindow(Controller c, NeuralNetworkWindow nn)
        {
            InitializeComponent();
            MaximizeBox = false;
            g = panel.CreateGraphics();
            this.c = c;
            this.nn = nn;
            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
            surface = new Bitmap(panel.Width, panel.Height);
            graph = Graphics.FromImage(surface);
            graph.SmoothingMode = SmoothingMode.HighQuality;
            panel.BackgroundImage = surface;
            panel.BackgroundImageLayout = ImageLayout.None;
            
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
                graph.DrawLine(p,old,current);
                old = current;
                panel.Invalidate();
            }
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            
            nn.UpdateGraphWithImg(surface);
            Close();
        }
        
        
    }
}