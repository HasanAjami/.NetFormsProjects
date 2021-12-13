using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Busfahrkarten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double anzahlH = Convert.ToDouble(anzahlHaltstellen.Value); //Anzahl der Haltstellen aus NumericUpDown1
            double alter = Convert.ToDouble(Alter.Value); //Alter aus NumericUpDown2

            double preisA = anzahlH * 0.15;
            double preisB;
            double preisC = anzahlH * 0.2;

            if(anzahlH >= 10)
            {
                preisA = preisA - (preisA * 0.3); //30 prozent Rabatt, wenn es mehr als 10 Haltstellen in A gibt
            }
        
            if(anzahlH <= 6)
            {
                preisB = 1.20;
            }
            else
            {
                preisB = 1.90;
            }

            if(alter < 12 || alter >= 60) // Halber Preis bei alter unter 12 oder ab 60
            {
                preisC = preisC / 2;
            }

            textBox1.Text = "Fahrpreis: "
            textBox1.Text += "Stadt A: " + preisA.ToString() + " EUR";
            textBox1.Text += "Stadt B: " + preisB.ToString() + " EUR";
            textBox1.Text += "Stadt C: " + preisC.ToString() + " EUR";

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
