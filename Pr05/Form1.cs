using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veta = textBox2.Text;
            int cislo = Convert.ToInt32(textBox1.Text);
            Retez Veta = new Retez(veta, cislo);
            Veta.Zkrat();


            label3.Text = Veta.ToString();
        }
    }
}
