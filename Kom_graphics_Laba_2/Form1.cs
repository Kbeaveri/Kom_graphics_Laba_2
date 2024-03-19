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
        float W;
        float H;
        float x_center;
        float y_center;
        float dx;
        float dy;
        Pen pen = new Pen(Color.Black);
        Font Fon = new Font("Arial", 9, FontStyle.Regular);
        Brush Br = Brushes.Black;
        float[][] CurrectPoint = new float[17][];
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            setDefault();
            W = this.pictureBox1.Width;
            H = this.pictureBox1.Height;
            x_center = W / 2;
            y_center = H / 2;
            dx = W / 30;
            dy = H /30;
        }
        private void setDefault()
        {
            textBox1.Text = "0";
            textBox3.Text = "0";
            returnBox.Checked = true;
            degreesBox.Text = "0";
            xBox.Text = "0";
            yBox.Text = "0";

            setCurrpoint();
        }
        private void setCurrpoint()
        {
            CurrectPoint[0] = new[] { x_center, y_center, 1 };
            CurrectPoint[1] = new[] { x_center + dx * 3, y_center + dy * -3, 1 };
            CurrectPoint[2] = new[] { x_center + dx * 3, y_center + dy * -5, 1 };
            CurrectPoint[3] = new[] { x_center + dx * 2, y_center + dy * -5, 1 };
            CurrectPoint[4] = new[] { x_center + dx * 3, y_center + dy * -7, 1 };
            CurrectPoint[5] = new[] { x_center + dx * 1, y_center + dy * -7, 1 };
            CurrectPoint[6] = new[] { x_center + dx * 0, y_center + dy * -9, 1 };
            CurrectPoint[7] = new[] { x_center + dx * -1, y_center + dy * -7, 1 };
            CurrectPoint[8] = new[] { x_center + dx * -3, y_center + dy * -7, 1 };
            CurrectPoint[9] = new[] { x_center + dx * -2, y_center + dy * -5, 1 };
            CurrectPoint[10] = new[] { x_center + dx * -3, y_center + dy * -5, 1 };
            CurrectPoint[11] = new[] { x_center + dx * -3, y_center + dy * -3, 1 };
            CurrectPoint[12] = new[] { x_center, y_center, 1 };
            CurrectPoint[13] = new[] { x_center + dx * 3, y_center + dy * -3, 1 };
            CurrectPoint[14] = new[] { x_center + dx * -3, y_center + dy * -3, 1 };
            CurrectPoint[15] = new[] { x_center + dx * -3, y_center + dy * -5, 1 };
            CurrectPoint[16] = new[] { x_center + dx * 3, y_center + dy * -5, 1 };
        }
        public void Draw(PointF[] CurrectPoint)
        {
            g.Clear(BackColor);
            g.DrawLine(Pens.Black, x_center, 0, x_center, H);
            g.DrawLine(Pens.Black, 0, y_center, W, y_center);
            Font Fon = new Font("Arial", 9, FontStyle.Regular);
            Brush Br = Brushes.Black;
            g.DrawString("X", Fon, Br, W - 15, y_center + 10);
            g.DrawString("Y", Fon, Br, x_center - 20, 10);
            for (int i = -15; i < 15; i++)
            {
                g.DrawString(i.ToString(), Fon, Br, x_center - 15, y_center + dy * i);
                g.DrawString(i.ToString(), Fon, Br, x_center + dx * i - 10, y_center + 10);
            }
            g.DrawLines(pen, CurrectPoint);
        }

        private void Drow_Click(object sender, EventArgs e)
        {
            if (returnBox.Checked == true)
            {
                setDefault();
            }
            if (textBox1.Text != "" && textBox1.Text != "0")
            {
                float a_float = (float)Convert.ToDouble(textBox1.Text);
                xOffset(CurrectPoint,dx*a_float);
            }
            if (textBox3.Text != "" && textBox3.Text != "0")
            {
                float a_float = (float)Convert.ToDouble(textBox3.Text);
                yOffset(CurrectPoint, -dy*a_float);
            }
            if (checkBoxX.Checked == true)
            {
                invertX(CurrectPoint);
            }
            if(checkBoxY.Checked == true)
            {
                invertY();
            }
            if (checkBoxXY.Checked == true)
            {
                invertXY();
            }
            if (degreesBox.Text != "0")
            {

            }
            Draw(ListToPoint(CurrectPoint));
        }
        private void xOffset(float[][] CurrectPoint,float offset)
        {
            for(int i = 0; i < CurrectPoint.Length; i++)
            {
                CurrectPoint[i][0] += offset;
            }
        }
        private void yOffset(float[][] CurrectPoint, float offset)
        {
            for (int i = 0; i < CurrectPoint.Length; i++)
            {
                CurrectPoint[i][1] += offset;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != '-' && number != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != '-' && number != '\b')
            {
                e.Handled = true;
            }
        }
        private void invertX(float[][] CurrectPoint)
        {
            float tmp;
            for (int i = 0; i < CurrectPoint.Length; i++)
            {
                tmp = y_center - CurrectPoint[i][1];
                CurrectPoint[i][1] = y_center+tmp;
            }
        }
        private void invertY()
        {
            float tmp;
            for (int i = 0; i < CurrectPoint.Length; i++)
            {
                tmp = x_center - CurrectPoint[i][0];
                CurrectPoint[i][0] = x_center + tmp;
            }
        }
        private void invertXY()
        {
            float tmp; 
            for (int i = 0; i < CurrectPoint.Length; i++)
            {
                tmp = CurrectPoint[i][0];
                CurrectPoint[i][0] = CurrectPoint[i][1];
                CurrectPoint[i][1] = tmp;
            }
        }

        private void turnNull(float[][] CurrectPoint) 
        { 

        }
        private void turn(float[][] CurrectPoint)
        {

        }
        private PointF[] ListToPoint(float[][] arr)
        {
            PointF[] result = new PointF[arr.Length];
            for (int i = 0;i <arr.Length;i++)
            {
                result [i] = new PointF(arr[i][0], arr[i][1]);
            }
            return result;
        }
    }
}
