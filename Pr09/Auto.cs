using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr09
{
    internal class Auto
    {
        private string znacka;
        private double spotreba; // spotřeba na 100km
        private int ujetoCelkem; // Celková ujetá vzdálenost během všech jednotlivých jízd (km)
        private DateTime rozjezd; // čas rozjezdu
        private double dobavsechjizd;
        public bool Jede { get; private set; }

        public Auto(string znacka, double spotreba)
        {
            this.znacka = znacka;
            this.spotreba = spotreba;
            ujetoCelkem = 0;
            dobavsechjizd = 0;
            Jede = false;
        }

        public int VratUjeteKm()
        {
            return ujetoCelkem;
        }

        public void Rozjed()
        {
            rozjezd = DateTime.Now;
            Jede = true;
         
        }

        public void Zastav (int ujeto)
        {
            if (Jede)
            {
                Jede = false;
                double rozdil = (DateTime.Now - rozjezd).TotalMinutes;
                dobavsechjizd += rozdil;
                ujetoCelkem += ujeto;
            }
        }

        public double CelkovaSpotreba()
        {
            double SpotrebaCelkem = (spotreba / ujetoCelkem) * 100;
            return SpotrebaCelkem;
        }

        public override string ToString()
        {
            return "Auto " + znacka + " má celkově najeto " + ujetoCelkem + " km, \n celková doba jízd " + dobavsechjizd + " minut,\n celková spotřeba " + CelkovaSpotreba();
        }

    }
}
