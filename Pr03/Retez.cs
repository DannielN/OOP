using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pr03
{
    internal class Retez
    {
        private string veta;

        public Retez(string veta)
        {
            this.veta = veta;
        }

        public int PocetSlov()
        {
            string[] slova = veta.Split(' ');
            int pocetslov = slova.Count();
            return pocetslov;
        }

        public void Smaz(char znak)
        {
            int index = 0;
            bool prosel = true;
            foreach (char znaky in veta)
            {
                prosel = true;
                if (znak == znaky)
                {
                    veta = veta.Remove(index, 1);
                    prosel = false;
                }
                if (!prosel) index--;

                index++;    
            }
        }

        public string Vypis()
        {
            return veta;
        }


    }
}
