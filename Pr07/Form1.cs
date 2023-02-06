using p07;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NakladniAuto auto;

        private void button1_Click(object sender, EventArgs e)
        {

            int hmotnost = Convert.ToInt32(textBox3.Text);
      
            auto.NalozNaklad(hmotnost);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vyloz = Convert.ToInt32(textBox4.Text);
            auto.VylozNaklad(vyloz);
            ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string spz = textBox1.Text;
            int nosnost = Convert.ToInt32(textBox2.Text);
            auto = new NakladniAuto(spz, nosnost);

        }
    }
}
