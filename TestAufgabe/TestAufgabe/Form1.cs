using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAufgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            double faktor1 = Convert.ToDouble(numericUpDown1.Value);
            double faktor2 = Convert.ToDouble(numericUpDown2.Value);

            double produkt = faktor1 * faktor2;

            textBoxAusgabe.Text = "Das Produkt ist: " + produkt.ToString();
        }
    }
}
