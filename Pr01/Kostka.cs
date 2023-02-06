using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01
{
    internal class Kostka
    {
        /// <summary>
        /// Generátor náhodných čísel
        /// </summary>
        private Random random;

        /// <summary>
        /// Počet stěn kostky
        /// </summary>
        private int pocetsten;


        public Kostka()
        {
            pocetsten = 6;
            random = new Random();
        }

        public int VratPocetSten()
        {
            return pocetsten;
        }

        public Kostka(int apocetSten)
        {
            pocetsten = apocetSten;
            random = new Random();
        }

        public override string ToString()
        {
            return "Kostka s " + pocetsten + " stěnami";
        }
        public int Hod()
        {
            return random.Next(1, pocetsten + 1);
        }
    }
}
