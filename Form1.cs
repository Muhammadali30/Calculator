using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        int first, second;
        char op;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text+= "3";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text= "";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            first = Convert.ToInt32(textBox1.Text);
            op = '+';
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (op == '+')
            {
                second = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(first + second);
            }
          else  if (op == '-')
            {
                second = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(first - second);
            }
           else if (op == '*')
            {
                second = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(first * second);
            }
           else if (op == '/')
            {
                second = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(first / second);
            }
            else if (op == '%')
            {
                second = Convert.ToInt32(textBox1.Text);
                textBox1.Text = Convert.ToString(first % second);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            first = Convert.ToInt32(textBox1.Text);
            op = '-';
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            first = Convert.ToInt32(textBox1.Text);
            op = '*';
            textBox1.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            first = Convert.ToInt32(textBox1.Text);
            op = '/';
            textBox1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            first = Convert.ToInt32(textBox1.Text);
            op = '%';
            textBox1.Text = "";
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox1.Text));
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double sqrtn = Math.Sqrt(Convert.ToInt32(textBox1.Text));
            textBox1.Text = Convert.ToString(sqrtn);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double cos = Math.Cos(Convert.ToInt32(textBox1.Text));
            textBox1.Text = Convert.ToString(cos);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double sinn = Math.Sin(Convert.ToInt32(textBox1.Text));
            textBox1.Text = Convert.ToString(sinn);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text =Convert.ToString (dateTimePicker2.Value - dateTimePicker1.Value);
            string[] word = textBox1.Text.Split('.');
            for (int i=0;i<1;i++)
            {
                textBox1.Text = word[0] + " Days";
            }
        }
        
    

        private void button10_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text)*-1;
            textBox1.Text = Convert.ToString(num);
            
        }
    }
}
