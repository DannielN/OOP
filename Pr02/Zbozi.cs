using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr02
{
    internal class Zbozi
    {
        private string nazevproduktu;
        private int cena;
        private DateTime datumVyroby;
        private int dnytrvanlivosti;

        public Zbozi (string nazevproduktu, int cena, DateTime datumVyroby, int dnytrvanlivosti)
        {
            this.nazevproduktu = nazevproduktu;
            this.cena = cena;
            this.datumVyroby = datumVyroby;
            this.dnytrvanlivosti = dnytrvanlivosti;
        }

        // Vrací za jak dlouho vyprší trvanlivost daného produktu
        public int MinTrvanlivostDny()
        {
         
            int MinTrvanlivost = 0;
            DateTime now = DateTime.Now;

             DateTime Vyprseni = datumVyroby.AddDays(dnytrvanlivosti);
            MinTrvanlivost = (Vyprseni - now).Days;

            return MinTrvanlivost;
        }

        public void NovaCena()
        {
            int MinTrvanlivost = MinTrvanlivostDny();

            if (MinTrvanlivost <= -10)
            {
                cena = 0;
            }

            else if (MinTrvanlivost <= 0)
            {
                cena = (cena * 50) / 100;
            }

            else if (MinTrvanlivost <= 3)
            {
                cena = (cena * 75) / 100;
            }
        }

        public string Vypis()
        {
            string text = string.Empty;
            int MinTrvanlivost = MinTrvanlivostDny();
            NovaCena();

            if (MinTrvanlivost <= 0)
            {
                if (cena == 0)
                {
                    text = "Produkt s názvem " + nazevproduktu + " zboží je neprodejné " + datumVyroby.ToString("dd/MM/yyyy") + " min trvanlivost " + dnytrvanlivosti + "dny, zboží je prošlé " + ((MinTrvanlivost) * -1) + " dny" ;
                } 
                else
                {
                    text = "Produkt s názvem " + nazevproduktu + " cena produktu " + cena + "kč Vyrobena byla " + datumVyroby.ToString("dd/MM/yyyy") + " min trvanlivost " + dnytrvanlivosti + "dny, zboží prošlo před " + ((MinTrvanlivost) * -1) + " dny" ;
                }
            }
            else
            {
                text = "Produkt s názvem " + nazevproduktu + " cena produktu " + cena + "kč Vyrobena byla " + datumVyroby.ToString("dd/MM/yyyy") + " min trvanlivost " + dnytrvanlivosti + "dny, do konce trvanlivosti zbývá " + MinTrvanlivost + " dny";
            }

            return text;
        }
    }
}
