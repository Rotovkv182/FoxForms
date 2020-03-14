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
        public int f;

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int a;
            int b;
            a = Convert.ToInt32(box1.Text);
            b = Convert.ToInt32(box2.Text);
            if (f == 0)
            {
                label1.Text = Convert.ToString(a + b);
            }
            if (f == 1)
            {
                label1.Text = Convert.ToString(a - b);
            }
            if (f == 2)
            {
                label1.Text = Convert.ToString(a * b);
            }
            if (f == 3)
            {
                label1.Text = Convert.ToString(a / b);
            }
        }

        private void Box1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            f = 0;
            label2.Text = "+";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            f = 1;
            label2.Text = "-";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            f = 2;
            label2.Text = "*";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            f = 3;
            label2.Text = "/";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            box1.Text = "";
            box2.Text = "";
            label1.Text = "";
        }
    }
}
