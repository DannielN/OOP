using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clovek clovek1 = new Clovek(textBox1.Text, Convert.ToDateTime(textBox2.Text));
            Clovek clovek2 = new Clovek(textBox3.Text, Convert.ToDateTime(textBox4.Text));

            MessageBox.Show(clovek1.ToString());
            MessageBox.Show(clovek2.ToString());

            MessageBox.Show(clovek1.Starsi(clovek2));
            
        }
    }
}
