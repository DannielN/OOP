using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Birthday2 = dateTimePicker2.Value;
            DateTime Birthday3 = dateTimePicker3.Value;
            DateTime Birthday4 = dateTimePicker4.Value;


            List<Student> students = new List<Student> ();
            students.Add(new Student ("Karel", "Dlouhý", Convert.ToDateTime("13.1.2003"), 4));
            students.Add(new Student("Marcel", "Holán",  Birthday2, 8));
            students.Add(new Student("David",  "Pavián", Birthday3, 2));
            students.Add(new Student("Marián", "Pošťák", Birthday4, 3));

            double soucet = 0;
            int pocet = 0;
            double prumer = 0;
            foreach(Student student in students)
            {
                if (student.Vek() >= 18)
                {
                    listBox1.Items.Add(student.ToString());
                }
                if (student.Znamka >= 1 && student.Znamka <= 5)
                {
                    soucet += student.Znamka;
                    pocet++;
                }
            }
            prumer = soucet / pocet;
            label1.Text = ("Průměrná známka je " + prumer);
        }
    }
}
