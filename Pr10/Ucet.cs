using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr10
{
    public enum StavEnum
    {
        Aktivni,
        Zablokovany,
        Zruseny
    }

    internal class Ucet
    {
        private int cislouctu;
        public string Jmeno { get; set; }
        private decimal obnos;

        static int pocitadlo = 0;
        private StavEnum status;

     

        public Ucet(string jmeno)
        {
            this.Jmeno = jmeno;
            pocitadlo ++;
            cislouctu = pocitadlo;
            status = StavEnum.Aktivni;
        }

        public void NastavStatus(StavEnum status)
        {
            this.status = status;
        }

        public void Vklad (decimal castka)
        {
            if (castka > 0)
            {
                if (status == StavEnum.Aktivni)
                {
                    obnos += castka;
                    MessageBox.Show("Přidal si na účet " + castka + " kč, obnos tvého účtu " + obnos + " vlastník účtu " + Jmeno + " číslo účtu " + cislouctu);
                }
                else if (status == StavEnum.Zablokovany)
                {
                    MessageBox.Show("Na účet " + cislouctu + " nemůžeš vkládat peníze, jelikož účet je zablokovaný");
                }
                else if (status == StavEnum.Zruseny)
                {
                    MessageBox.Show("Na účet " +cislouctu + " nemůžeš vkládat peníze, jelikož účet je zrušený");
                }
            }
        }

        public void Vyber (decimal castka)
        {
            if (obnos >= castka)
            {
                if (status == StavEnum.Aktivni)
                {
                    obnos -= castka;
                    MessageBox.Show("Vybral si z účtu " + castka + " kč, obnos tvého účtu " + obnos + " vlastník účtu " + Jmeno + " číslo účtu " + cislouctu);
                }
                else if (status == StavEnum.Zablokovany)
                {
                    MessageBox.Show("Z účtu " + cislouctu + " nemůžeš vybírat peníze, jelikož účet je zablokovaný");
                }
                else if (status == StavEnum.Zruseny)
                {
                    MessageBox.Show("Z účtu " + cislouctu + " nemůžeš vybírat peníze, jelikož účet je zrušený");
                }
            }
            else
            {
                MessageBox.Show("Nemůžeš vybírat z prázdného účtu");
            }
        }

    }
}
