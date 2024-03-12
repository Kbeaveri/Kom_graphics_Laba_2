using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kom_graphics_Laba_2
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }
        public void Draw()
        {
            int W = this.pictureBox1.Width;
            int H = this.pictureBox1.Height;
            int x_center = W / 2;
            int y_center = H / 2;
            int dx = W / 30;
            int dy = H / 30;
            g.DrawLine(Pens.Black, x_center, 0, x_center, H);
            g.DrawLine(Pens.Black, 0, y_center, W, y_center);
            Font Fon = new Font("Arial", 9, FontStyle.Regular);
            Brush Br = Brushes.Black;
            g.DrawString("X", Fon, Br, W - 15, y_center + 10);
            g.DrawString("Y", Fon, Br, x_center - 20, 10);
            Font Fon1 = new Font("Arial", 10, FontStyle.Regular);
            for (int i = -15; i < 15; i++)
            {
                g.DrawString(i.ToString(), Fon1, Br, x_center - 15, y_center + dy * i);
                g.DrawString(i.ToString(), Fon1, Br, x_center + dx * i - 10, y_center + 10);
            }
            Point[] CurrectPoint = new Point[17];
            CurrectPoint[0] = (new Point(x_center, y_center));
            CurrectPoint[1] = (new Point(x_center + dx * 3, y_center + dy * -3));
            CurrectPoint[2] = (new Point(x_center + dx * 3, y_center + dy * -5));
            CurrectPoint[3] = (new Point(x_center + dx * 2, y_center + dy * -5));
            CurrectPoint[4] = (new Point(x_center + dx * 3, y_center + dy * -7));
            CurrectPoint[5] = (new Point(x_center + dx * 1, y_center + dy * -7));
            CurrectPoint[6] = (new Point(x_center + dx * 0, y_center + dy * -9));
            CurrectPoint[7] = (new Point(x_center + dx * -1, y_center + dy * -7));
            CurrectPoint[8] = (new Point(x_center + dx * -3, y_center + dy * -7));
            CurrectPoint[9] = (new Point(x_center + dx * -2, y_center + dy * -5));
            CurrectPoint[10] = (new Point(x_center + dx * -3, y_center + dy * -5));
            CurrectPoint[11] = (new Point(x_center + dx * -3, y_center + dy * -3));
            CurrectPoint[12] = (new Point(x_center, y_center));
            CurrectPoint[13] = (new Point(x_center + dx * 3, y_center + dy * -3));
            CurrectPoint[14] = (new Point(x_center + dx * -3, y_center + dy * -3));
            CurrectPoint[15] = (new Point(x_center + dx * -3, y_center + dy * -5));
            CurrectPoint[16] = (new Point(x_center + dx * 3, y_center + dy * -5));
            Pen pen = new Pen(Color.Black);
            g.DrawLines(pen, CurrectPoint);
        }

        private void Drow_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
