using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pr05
{
    internal class Retez
    {
        private string veta;
        private int cislo;

        public string Veta
        {
            get
            {
                return veta;
            }
            set
            {
                veta = value;
                veta = veta.Substring(0, 1).ToUpper() + veta.Substring(1);

                if (veta[veta.Length - 1] != '.')
                {
                    veta += '.';
                }
            }
        }

        public Retez(string veta)
        {
            Veta = veta;
            cislo = 1;
        }

        public Retez(string veta, int cislo)
        {
            Veta = veta;
            this.cislo = cislo;
        }


        public override string ToString()
        {
            return Veta;
        }

        public void Zkrat()
        {
            string[] slova = Veta.Split(' ');
            string vet = string.Empty;

            for (int k = 0; k < slova.Count(); k++)
            {
                if (cislo <= 0)
                {
                    vet = "";
                }
                else
                {
                    if (k != cislo)
                    {
                        vet += slova[k] + " ";
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Veta = vet;
        }
    }
}
