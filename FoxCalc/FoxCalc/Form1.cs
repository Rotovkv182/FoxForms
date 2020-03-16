using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoxCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int a, b;
        public int temp;

        private void N0_Click(object sender, EventArgs e)
        {
            box1.Text = box1.Text + 0;
        }

        private void N1_Click(object sender, EventArgs e)
        {
            box1.Text = box1.Text + 1;
        }

        private void N2_Click(object sender, EventArgs e)
        {
            box1.Text = box1.Text + 2;
        }

        private void N3_Click(object sender, EventArgs e)
        {
            box1.Text = box1.Text + 3;
        }

        private void N4_Click(object sender, EventArgs e)
        {
            box1.Text = box1.Text + 4;
        }

        private void N5_Click(object sender, EventArgs e)
        {
            box1.Text = box1.Text + 5;
        }

        private void N6_Click(object sender, EventArgs e)
        {
            box1.Text = box1.Text + 6;
        }

        private void N7_Click(object sender, EventArgs e)
        {
            box1.Text = box1.Text + 7;
        }

        private void N8_Click(object sender, EventArgs e)
        {
            box1.Text = box1.Text + 8;
        }

        private void N9_Click(object sender, EventArgs e)
        {
            box1.Text = box1.Text + 9;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"{a}+";
            box1.Clear();
            box1.Focus();
            temp = 1;
            label2.Text = "+";
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"{a}-";
            box1.Clear();
            box1.Focus();
            temp = 2;
            label2.Text = "-";
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"{a}*";
            box1.Clear();
            box1.Focus();
            temp = 3;
            label2.Text = "*";
        }

        private void Segment_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(box1.Text);
            label1.Text = $"{a}/";
            box1.Clear();
            box1.Focus();
            temp = 4;
            label2.Text = "/";
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Calc(temp);
            box1.Text = Convert.ToString(b);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            box1.Clear();
            a = 0;
            b = 0;
        }
        public void Calc(int temp)
        {
            switch (temp)
            {
                case 1:
                    b = a + Convert.ToInt32(box1.Text);
                    box1.Text = b.ToString();
                    break;
                case 2:
                    b = a - Convert.ToInt32(box1.Text);
                    box1.Text = b.ToString();
                    break;
                case 3:
                    b = a * Convert.ToInt32(box1.Text);
                    box1.Text = b.ToString();
                    break;
                case 4:
                    b = a / Convert.ToInt32(box1.Text);
                    box1.Text = b.ToString();
                    break;
                default:
                    break;
            }
        }
    }
}