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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        public float numberOfTextBox1, numberOfTextBox2;
        public int count;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(',') == -1)
            {
                textBox1.Text += ",";
            }
            
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            numberOfTextBox1 = float.Parse(textBox1.Text);
            count = 2;
            textBox2.Text = numberOfTextBox1.ToString() + "-";

            Console.Out.WriteLine("a: " + numberOfTextBox1.ToString() + "b: " + numberOfTextBox2.ToString());

            if (numberOfTextBox2 > 0)
            {
                Console.WriteLine("a: " + numberOfTextBox1.ToString() + "b: " + numberOfTextBox2.ToString());
                numberOfTextBox2 = numberOfTextBox2 - numberOfTextBox1;
                textBox2.Text = numberOfTextBox2.ToString() + "-";
            }
            else
            {
                numberOfTextBox2 = numberOfTextBox1;
            }

            textBox1.Clear();
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            numberOfTextBox1 = float.Parse(textBox1.Text);
            count = 3;
            textBox2.Text = numberOfTextBox2.ToString() + "*";

            Console.Out.WriteLine("a: " + numberOfTextBox1.ToString() + "b: " + numberOfTextBox2.ToString());

            if (numberOfTextBox2 > 0)
            {
                Console.WriteLine("a: " + numberOfTextBox1.ToString() + "b: " + numberOfTextBox2.ToString());
                numberOfTextBox2 = numberOfTextBox2 * numberOfTextBox1;
                textBox2.Text = numberOfTextBox2.ToString() + "*";
            }
            else
            {
                numberOfTextBox2 = numberOfTextBox1;
            }

            textBox1.Clear();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            numberOfTextBox1 = float.Parse(textBox1.Text); 
            count = 4;
            textBox2.Text = numberOfTextBox2.ToString() + "/";

            Console.Out.WriteLine("a: " + numberOfTextBox1.ToString() + "b: " + numberOfTextBox2.ToString());

            if (numberOfTextBox2 > 0)
            {
                Console.WriteLine("a: " + numberOfTextBox1.ToString() + "b: " + numberOfTextBox2.ToString());
                numberOfTextBox2 = numberOfTextBox2 / numberOfTextBox1;
                textBox2.Text = numberOfTextBox2.ToString() + "/";
            }
            else
            {
                numberOfTextBox2 = numberOfTextBox1;
            }

            textBox1.Clear();



        }

        private void Button15_Click(object sender, EventArgs e)
        {
            calculate();
            textBox1.Text = "";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            { 
            numberOfTextBox1 = float.Parse(textBox1.Text);
            textBox2.Text = numberOfTextBox2.ToString() + "+";
            count = 1;
            Console.Out.WriteLine("a: " + numberOfTextBox1.ToString() + "b: " + numberOfTextBox2.ToString());

            if (numberOfTextBox2 >= 0)
            {
                Console.WriteLine("a: " + numberOfTextBox1.ToString() + "b: " + numberOfTextBox2.ToString());
                numberOfTextBox2 = numberOfTextBox2 + numberOfTextBox1;
                textBox2.Text = numberOfTextBox2.ToString() + "+";
            }
            else
            {
                numberOfTextBox2 = numberOfTextBox1;
            }

            textBox1.Clear();
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    numberOfTextBox2 = numberOfTextBox1 + float.Parse(textBox1.Text);
                    textBox2.Text = numberOfTextBox2.ToString();
                    break;
                case 2:
                    numberOfTextBox2 = numberOfTextBox1 - float.Parse(textBox1.Text);
                    textBox2.Text = numberOfTextBox2.ToString();
                    break;
                case 3:
                    numberOfTextBox2 = numberOfTextBox1 * float.Parse(textBox1.Text);
                    textBox2.Text = numberOfTextBox2.ToString();
                    break;
                case 4:
                    float divider;
                    divider = float.Parse(textBox1.Text);
                    if (divider == 0.0)
                        MessageBox.Show("Внимание! Деление на ноль!");
                    else
                    {
                        numberOfTextBox2 = numberOfTextBox1 / divider;
                        textBox2.Text = numberOfTextBox2.ToString();

                        numberOfTextBox2 = numberOfTextBox1 / float.Parse(textBox1.Text);
                        textBox2.Text = numberOfTextBox2.ToString();
                     }
                    break;

                default:
                    break;
            }

        }
    }
}
