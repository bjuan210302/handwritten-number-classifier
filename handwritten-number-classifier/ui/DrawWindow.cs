using System;
using System.Drawing;
using System.Windows.Forms;
using handwritten_number_classifier.Model;
using NumSharp;

namespace handwritten_number_classifier.ui
{
    public partial class DrawWindow : Form
    {
        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black, 30);
        public Graphics g;
        public Controller c;
        private Bitmap surface;
        private Graphics graph;
        
        public DrawWindow(Controller c)
        {
            InitializeComponent();
            g = panel.CreateGraphics();
            this.c = c;
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
            surface = new Bitmap(panel.Width, panel.Height);
            graph = Graphics.FromImage(surface);
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
            //Bitmap newImg = ScaleImage(surface, 28, 28);
            Bitmap newImg = new Bitmap(surface, new Size(28, 28));
            newImg.Save("newImg");
        }
        
        private Bitmap ScaleImage(Bitmap bmp, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / bmp.Width;
            var ratioY = (double)maxHeight / bmp.Height;
            var ratio = Math.Min(ratioX, ratioY);
         
            var newWidth = (int)(bmp.Width * ratio);
            var newHeight = (int)(bmp.Height * ratio);
         
            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
            {
                graphics.DrawImage(bmp, 0, 0, newWidth, newHeight);
                graphics.Dispose();
            }
                
            
         
            return newImage;
        }
    }
}