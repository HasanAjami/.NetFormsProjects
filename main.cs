using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace _3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void orderNum(int a, int b, int c){
            if (a <= b)
                {
                    if (a <= c)
                    {
                        textBox1.Text += a.ToString() + " - ";
                        if (b <= c)
                        {
                            textBox1.Text += b.ToString() + " - ";
                            textBox1.Text += c.ToString() + "\r\n";
                            if(a == 1 && b == 2 && c == 3)
                            {
                                jackbot = true;
                            }
                        }
                        else
                        {
                            textBox1.Text += c.ToString() + " - ";
                            textBox1.Text += b.ToString() + "\r\n";
                            if (a == 1 && c == 2 && b == 3)
                            {
                                jackbot = true;
                            }
                        }
                    }
                    else
                    {
                        textBox1.Text += c.ToString() + " - ";
                        textBox1.Text += a.ToString() + " - ";
                        textBox1.Text += b.ToString() + "\r\n";
                        if (c == 1 && a == 2 && b == 3)
                        {
                            jackbot = true;
                        }
                    }
                }
                else
                {
                    if (b <= c)
                    {
                        textBox1.Text += b.ToString() + " - ";
                        if (a <= c)
                        {
                            textBox1.Text += a.ToString() + " - ";
                            textBox1.Text += c.ToString() + "\r\n";
                            if (b == 1 && a == 2 && c == 3)
                            {
                                jackbot = true;
                            }
                        }
                        else
                        {
                            textBox1.Text += c.ToString() + " - ";
                            textBox1.Text += a.ToString() + "\r\n";
                            if (b == 1 && c == 2 && a == 3)
                            {
                                jackbot = true;
                            }
                        }
                    }
                    else
                    {
                        textBox1.Text += c.ToString() + " - ";
                        textBox1.Text += b.ToString() + " - ";
                        textBox1.Text += a.ToString() + "\r\n";
                        if (c == 1 && b == 2 && a == 3)
                        {
                            jackbot = true;
                        }
                    }
                }
        }

        private void button1_Click(object sender, EventArgs e) //assigned to "button1" in Form App
        {
            Random zufall = new Random(); //random number
 
            int a;
            int b;
            int c;
            int n = 0;
 
            bool jackbot = false;           //True when the number combination 1-2-3 occurs
 
            do
            {
                a = zufall.Next(1, 7);
                do
                {
                    b = zufall.Next(1, 7);
 
                } while (b == a);
 
                do
                {
 
                    c = zufall.Next(1, 7);
 
                } while (c == b || c == a);
 
                orderNum(a, b, c);

                n += 1;
            } while (!jackbot);
 
            textBox1.Text += n.ToString();
 
        }
    }
}
