using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace broetchen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            double anzahl = Convert.ToDouble(numericUpDown1.Value);

            double preis = anzahl * 0.45;

            if(checkBox1.Checked == true) //Wenn CheckBox für Geschenktüte gecheckt, dann sollte 1.20€ addiert werden
            {
                preis = preis + 1.2;
            }

            if(anzahl <= 15)
            {
                textBox1.Text = "Zu zahlen: " + preis.ToString() + " EUR";
            }
            else
            {
                textBox1.Text = "---"; //Fehlermeldung
            }
             
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
