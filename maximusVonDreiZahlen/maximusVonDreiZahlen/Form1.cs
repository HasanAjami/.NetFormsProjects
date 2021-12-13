using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maximusVonDreiZahlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = Convert.ToInt32(numericUpDown1.Value);
            int b = Convert.ToInt32(numericUpDown2.Value);
            int c = Convert.ToInt32(numericUpDown3.Value);

            if(a > b && a > c)
            {
                textBox1.Text = "Die größte Zahl ist " + a.ToString();
            }else if(c > b)
            {
                textBox1.Text = "Die größte Zahl ist " + c.ToString();
            }
            else
            {
                textBox1.Text = "Die größte Zahl ist " + b.ToString();
            }



        }
    }
}
