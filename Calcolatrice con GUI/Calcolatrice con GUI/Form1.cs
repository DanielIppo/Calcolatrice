using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice_con_GUI
{
    public partial class Form1 : Form
    {
        public double n1 = 0;
        public double n2 = 0;
        public bool operatore = false;
        public int operazioneAritmetica = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                textBox2.Text = "" + 0;
                operatore = false;
            }
            else
            {
                textBox2.Text += 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)//1
        {
            if (operatore == true)
            {
                textBox2.Text = "" + 1;
                operatore = false;
            }
            else
            {
                textBox2.Text += 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                textBox2.Text = "" + 2;
                operatore = false;
            }
            else
            {
                textBox2.Text += 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                textBox2.Text = "" + 3;
                operatore = false;
            }
            else
            {
                textBox2.Text += 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                textBox2.Text = "" + 4;
                operatore = false;
            }
            else
            {
                textBox2.Text += 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                textBox2.Text = "" + 5;
                operatore = false;
            }
            else
            {
                textBox2.Text += 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                textBox2.Text = "" + 6;
                operatore = false;
            }
            else
            {
                textBox2.Text += 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                textBox2.Text = "" + 7;
                operatore = false;
            }
            else
            {
                textBox2.Text += 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                textBox2.Text = "" + 8;
                operatore = false;
            }
            else
            {
                textBox2.Text += 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                textBox2.Text = "" + 9;
                operatore = false;
            }
            else
            {
                textBox2.Text += 9;
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (operatore == true)
            {
                textBox2.Text = "" + ",";
                operatore = false;
            }
            else
            {
                textBox2.Text += ",";
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operazioneAritmetica)
            {
                case 1: //Addizione 
                    n2 = Convert.ToDouble(textBox2.Text);
                    n1 = n1 + n2;
                    textBox2.Text = Convert.ToString(n1);
                    n1 = 0;
                    n2 = 0;
                    operatore = true;
                    operazioneAritmetica = 5;
                    break;
                case 2: //Sottrazione
                    n2 = Convert.ToDouble(textBox2.Text);
                    n1 = n1 - n2;
                    textBox2.Text = Convert.ToString(n1);
                    n1 = 0;
                    n2 = 0;
                    operatore = true;
                    operazioneAritmetica = 5;
                    break;
                case 3: //Moltiplicazione
                    n2 = Convert.ToDouble(textBox2.Text);
                    n1 = n1 * n2;
                    textBox2.Text = Convert.ToString(n1);
                    n1 = 0;
                    n2 = 0;
                    operatore = true;
                    operazioneAritmetica = 5;
                    break;
                case 4: //Divisione
                    n2 = Convert.ToDouble(textBox2.Text);
                    n1 = n1 / n2;
                    textBox2.Text = Convert.ToString(n1);
                    n1 = 0;
                    n2 = 0;
                    operatore = true;
                    operazioneAritmetica = 5;
                    break;
                case 5:
                    textBox2.Text = textBox2.Text;
                    break;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)//ADDIZIONE 
        {
            if (n1 == 0)
            {
                if (textBox2.Text == "")
                {
                    textBox2.Text = "0";
                }
                n1 = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 1;
            }
            else
            {
                n2 = Convert.ToDouble(textBox2.Text);
                n1 += n2;
                textBox2.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 1;
            }


        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                if (textBox2.Text == "")
                {
                    textBox2.Text = "0";
                }
                n1 = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 2;
            }
            else
            {
                n2 = Convert.ToDouble(textBox2.Text);
                n1 -= n2;
                textBox2.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 2;
            }
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                if (textBox2.Text == "")
                {
                    textBox2.Text = "0";
                }
                n1 = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 3;
            }
            else
            {
                n2 = Convert.ToDouble(textBox2.Text);
                n1 *= n2;
                textBox2.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 3;
            }
        }

        private void buttonDividedBy_Click(object sender, EventArgs e)
        {
            if (n1 == 0)
            {
                if (textBox2.Text == "")
                {
                    textBox2.Text = "0";
                }
                n1 = Convert.ToDouble(textBox2.Text);
                textBox2.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 4;
            }
            else
            {
                n2 = Convert.ToDouble(textBox2.Text);
                n1 /= n2;
                textBox2.Text = Convert.ToString(n1);
                operatore = true;
                operazioneAritmetica = 4;
            }
        }

        private void buttonCanc_Click(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            operatore = false;
            operazioneAritmetica = 0;
            textBox2.Text = "";
    }

        private void textBox2_TextChanged(object sender, EventArgs e)//TESTO
        {

        }

        
    }
}
