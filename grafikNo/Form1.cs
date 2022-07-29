using System;
using System.Drawing;
using System.Windows.Forms;

namespace grafikNo
{
    public partial class Form1 : Form
    {

        int x, y;
        Graphics g;
        Pen p = new Pen(Color.FromArgb(255, 0, 0));
        Font f = new Font("Arial", 10);
        SolidBrush b = new SolidBrush(Color.Black);
        int s = 0;
        public Form1()
        {
            InitializeComponent();
        }

        /*
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /*Graphics g = e.Graphics;
            g.DrawLine(Pens.Black, new PointF(0f, 0f), new PointF(150f, 150f));

            Pen p = new Pen(Color.FromArgb(255, 0, 0));
            p.Width = 3;

            g.DrawLine(p, new PointF(20f, 80f), new PointF(200f, 40f));

            p.Color = Color.FromArgb(255, 0, 255);
            p.Width = 5;
            g.DrawEllipse(p, new RectangleF(100f,100f,100f,100f));
            
        } */

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = Convert.ToString(e.X);
            label2.Text = Convert.ToString(e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Refresh();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;

            g = panel1.CreateGraphics();
            p.Width = 2;

            if (s < 10) {
                g.DrawEllipse(p, new RectangleF(x, y, 15, 15));
                g.DrawString(Convert.ToString(s), f, b, x+2 , y );
                s++;
            }

            
            


        }


    }
}
