using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zdravice zdravice = new Zdravice();
            zdravice.text = textBox2.Text;
            Kostka hod = new Kostka();

            

            Kostka kostka;

            if (textBox3.Text != "")
            {
                int pocet = Convert.ToInt32(textBox3.Text);
                kostka = new Kostka(pocet);
            }
            else
            {
                 kostka = new Kostka();
            }

            MessageBox.Show(zdravice.Pozdrav(textBox1.Text) + " " + kostka.ToString() + " hodil jsi číslo " + kostka.Hod());
        }
    }
}
