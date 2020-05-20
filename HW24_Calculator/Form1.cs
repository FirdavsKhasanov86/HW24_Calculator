using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW24_Calculator
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public double memory;
        public bool memFlag;

        public Form1()
        {
            n2 = false;
            InitializeComponent();

            button9.Enabled = false;
            button8.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            

            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "*")
            {
                res = dn1 * dn2;
            }
            if (D == "/")
            {
                //if (dn1 > 0 && dn2 > 0)
                //{
                    res = dn1 / dn2;
                //}
                //else
                //{
                      
                //    var er = Convert.ToString(res);

                //      er = textBox1.Text = "Error";
                //}
                
            }
            if (D == "%")
            {
                res = dn1 / 100 * dn2;
            }
            D = "=";
            n2 = true;
            
            textBox1.Text = res.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = 1 / dn;
            textBox1.Text = res.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double dn, res;

            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        //MC
        private void button9_Click(object sender, EventArgs e)
        {

            textBox1.Text = "0";
            memory = 0;
            button9.Enabled = false;
            button8.Enabled = false;
        }
        //MS
        private void button7_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(textBox1.Text);
            button9.Enabled = true;
            button8.Enabled = true;
            memFlag = true;
        }

        //MR
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
            memFlag = true;
        }

        //M+
        private void button6_Click(object sender, EventArgs e)
        {
            memory += Double.Parse(textBox1.Text);
        }
    }
}
