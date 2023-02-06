using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr04
{
    internal class Clovek
    {
        private string jmeno;
        private DateTime narozen;

        public Clovek (string jmeno, DateTime narozen)
        {
            this.jmeno = jmeno;
            this.narozen = narozen;
        }

        public void NastavJmeno(string NoveJmeno)
        {
            jmeno = NoveJmeno;
        }

        public string VypisJmeno()
        {
            string Zprava = string.Empty;

            Zprava = "Ahoj " + jmeno + " ! ";

            return Zprava;
        }

        public int Vek()
        {
            int vek = 0;
            DateTime now = DateTime.Now;
            vek = now.Year - narozen.Year;
            if (now.DayOfYear < narozen.DayOfYear) vek--;
            
            return vek;
        }

        public bool Plnolety()
        {
            bool JePlnolety = true;
            if (Vek() >= 18)
            {
                JePlnolety = true;
            }
            else 
            { 
                JePlnolety = false; 
            }

            return JePlnolety;
        }

        public string Starsi(Clovek druhyclovek)
        {
            if (druhyclovek.narozen > narozen)
            {
                return "První člověk je starší než druhý ";
            }
            else
            {
                return "Druhý človek je starší než první ";
            }
        }

        public override string ToString()
        {
            if (Plnolety() == true) return (VypisJmeno() + " počet roků " + Vek() + " je plnoletý ! ");
            else return(VypisJmeno() + " počet roků " + Vek() + " není plnoletý ! ");

        }
    }
}
