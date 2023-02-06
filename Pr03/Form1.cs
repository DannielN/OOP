using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            char znak = Convert.ToChar(textBox2.Text);

            Retez veta = new Retez(text);

            
            MessageBox.Show("Původní text: " + veta.Vypis());
            MessageBox.Show("Počet slov v řetězci " + veta.PocetSlov());

            veta.Smaz(znak);

            MessageBox.Show("Upravený text: " + veta.Vypis());
        }
    }
}
