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
            //Z = p * k/100
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k = 1;
            double p = Convert.ToDouble(numericUpDown1.Value);
            double n = 0;
            double z ;

            textBox1.Text += "Anfang: \r\n" + k.ToString();
            do
            {
                z = (p * k) / 100;
                k += z;

                textBox1.Text += "Nach Jahr " + n.ToString() + ": " + k.ToString("n2") + " EUR \r\n"; 


                n += 1;
            } while (k < 2);

            label1.Text = "Verdopplung nach " + n.ToString() + " Jahren";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
