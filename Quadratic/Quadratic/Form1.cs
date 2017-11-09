using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Solve;


namespace class1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                QuadraticEquation y = new QuadraticEquation(a, b, c);
                double delta = y.calculateDelta();
                double root1 = y.calculateX1();
                double root2 = y.calculateX2();
                if(delta>0)
                {
                    label9.Text = root1.ToString();
                    label10.Text = root2.ToString();
                }
                if (delta == 0)
                {
                    label10.Text = "Double root";
                }
                if (delta <0)
                {
                label9.Text = "No roots";
                label10.Text = "No roots";
                }
                label8.Text = delta.ToString();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
