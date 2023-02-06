using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Pr08
{
    internal class Atlet
    {
        private String jmeno;
        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                jmeno = value;
                jmeno = jmeno[0].ToString().ToUpper() + jmeno.Substring(1);
            }
        }

        private int unava;

        public Atlet(string Jmeno)
        {
            this.Jmeno = Jmeno;
            unava = 0;
        }

        public void Behej(int vzdalenost)
        {
            for (int k = 0; k < vzdalenost; k++)
            {
                unava += 10;
                MessageBox.Show("Unava : " + unava + " odběhnutých kilometrů " + (k + 1));
                if (unava == 200)
                {
                    MessageBox.Show(Jmeno + " už nemůže !");
                    break;
                }
            }
        }

        public void Spi(int spanek)
        {
            for (int k = 1; k <= spanek; k++)
            {
                unava -= 100;

                if (unava < 0)
                {
                    unava = 0;
                    break;
                }

                MessageBox.Show("Unava : " + unava + " Zbývá ti " + (spanek - k) + " hodin spánku");

            }
        }

        public void ZjistiUnavu()
        {
            MessageBox.Show("Momentální únava " + unava);
        }
        
    }
}
