using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr06
{
    internal class Student
    {
        public string Jmeno { get; }
        public string Prijmeni { get; set; }
        private DateTime birthday;
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
                if (birthday > DateTime.Today)
                {
                    MessageBox.Show("Budoucí datum");
                }
            }
        }
        private int znamka;
        public int Znamka
        {
            get
            {
                if (znamka == 0) 
  
                {
                    MessageBox.Show("Klasifikace neproběhla");
                }
                return znamka;
            }
            set
            {
                znamka = value;

                if (znamka < 1 || znamka > 5)
                {
                    znamka = 0;
                }
            }
        }

        // kontrola budoucího data, a nastavení známky
        // instance
       public Student(string jmeno, string prijmeni, DateTime birthday, int znamka)
        {
            this.Jmeno = jmeno;
            this.Prijmeni = prijmeni;
            Birthday = birthday;
            Znamka = znamka;
        }

        public int Vek()
        {
            int age = 0;

            DateTime now = DateTime.Now;
            age = now.Year - birthday.Year;

            if (now < birthday.AddYears(age))
            {
                age--;
            }

            return age;
            /*
            vek = now.Year - birthday.Year;
            if (now.DayOfYear < birthday.DayOfYear) vek--;
            */
        }

        public bool Sleva()
        {
            if (Vek() < 26) return true;
           
            return false;
           
        }

        public override string ToString()
        {
            if (Sleva())
            {
                return "Student " + Jmeno + " " + Prijmeni + " je mu" + Vek() + " let, má nárok na slevu" + Znamka;
            }
            else
            {
                return "Student " + Jmeno + " " + Prijmeni + " je mu" + Vek() + " let, nemá nárok na slevu" + Znamka;
            }
        }

        
        

    }
}
