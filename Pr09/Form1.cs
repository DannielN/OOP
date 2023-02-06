using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Auto car;
        private void button1_Click(object sender, EventArgs e) // ujeté km
        {
            

            listBox1.Items.Add("Ujete km : " + car.VratUjeteKm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // rozjezd
            car.Rozjed();
            listBox1.Items.Add("Čas rozjezdu " + DateTime.Now);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            car.Zastav(10);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            car = new Auto("Škoda", 5.2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Celková spotřeba auta " + car.CelkovaSpotreba());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = car.ToString();
        }
    }
}
