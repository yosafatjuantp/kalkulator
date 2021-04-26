using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator_3103118142
{
    public partial class Form1 : Form
    {
        double n1;
        double n2;
        double hasil;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                op = "+";
                textBox2.Text = n1 + "+";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please input a number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonmin_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                op = "-";
                textBox2.Text = n1 + "-";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please input a number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonkali_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                op = "*";
                textBox2.Text = n1 + "*";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please input a number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonbagi_Click(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "0";
                op = "/";
                textBox2.Text = n1 + "/";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Please input a number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = null;
        }

        private void buttonkoma_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void buttonhasil_Click(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(textBox1.Text);

            if (op == "+")
            {
                hasil = (n1 + n2);
                textBox1.Text = Convert.ToString(hasil);
                textBox2.Text = n1 + "+" + n2 + "=";
                n1 = hasil;
            }
            if (op == "-")
            {
                hasil = (n1 - n2);
                textBox1.Text = Convert.ToString(hasil);
                textBox2.Text = n1 + "-" + n2 + "=";
                n1 = hasil;
            }
            if (op == "*")
            {
                hasil = (n1 * n2);
                textBox1.Text = Convert.ToString(hasil);
                textBox2.Text = n1 + "*" + n2 + "=";
                n1 = hasil;
            }
            if (op == "/")
            {
                if (n2 == 0)
                {
                    MessageBox.Show("Tidak bisa dibagi 0");
                }
                else
                {
                    hasil = (n1 / n2);
                    textBox1.Text = Convert.ToString(hasil);
                    textBox2.Text = n1 + "/" + n2 + "=";
                    n1 = hasil;
                }
            }
            if (op == "^")
            {
                if (n2 == 0)
                {
                    hasil = 1;
                    textBox1.Text = Convert.ToString(hasil);
                    textBox2.Text = n1 + "^" + n2 + "=";
                    n1 = hasil;
                }
                else
                {
                    hasil = Math.Pow(n1, n2);
                    textBox1.Text = Convert.ToString(hasil);
                    textBox2.Text = n1 + "^" + n2 + "=";
                    n1 = hasil;
                }
            }
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
