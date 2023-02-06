using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string NazevProduku = textBox1.Text;
            int cenaproduktu = Convert.ToInt32(textBox2.Text);
            DateTime DatumVyroby = Convert.ToDateTime(dateTimePicker1.Text);
            int TrvanlivostDny = Convert.ToInt32(textBox4.Text);


            Zbozi produkt = new Zbozi(NazevProduku, cenaproduktu, DatumVyroby, TrvanlivostDny);

            MessageBox.Show(produkt.Vypis());
        }
    }
}
