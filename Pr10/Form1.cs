using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ucet Newucet;
        private void button1_Click(object sender, EventArgs e)
        {
            Newucet = new Ucet(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) Newucet.NastavStatus(StavEnum.Aktivni);
            else if (radioButton2.Checked) Newucet.NastavStatus(StavEnum.Zablokovany);
            else if (radioButton3.Checked) Newucet.NastavStatus(StavEnum.Zruseny);
            Newucet.Vklad(Convert.ToDecimal(textBox1.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) Newucet.NastavStatus(StavEnum.Aktivni);
            else if (radioButton2.Checked) Newucet.NastavStatus(StavEnum.Zablokovany);
            else if (radioButton3.Checked) Newucet.NastavStatus(StavEnum.Zruseny);
            Newucet.Vyber(Convert.ToDecimal(textBox1.Text));
        }
    }
}
