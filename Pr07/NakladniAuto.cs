using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p07
{
    internal class NakladniAuto
    {

        private string spz;

        private int nosnost; //v tunach

        public int HmotnostNakladu { get; private set; } //v tunach

        public NakladniAuto(string spz, int nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
            HmotnostNakladu = 0;
        }

        public void NalozNaklad(int nalozit)
        {
            int misto = nosnost - HmotnostNakladu;
            if (nalozit <= misto) HmotnostNakladu += nalozit;
            else
            {
                nalozit -= misto;
                HmotnostNakladu += misto;


                MessageBox.Show(String.Format($"{nalozit} tun nebylo naloženo"));
            }
        }

        public void VylozNaklad(int vylozit)
        {
            if (vylozit <= HmotnostNakladu) HmotnostNakladu -= vylozit;
            else
            {
                double chybi = vylozit - HmotnostNakladu;
                HmotnostNakladu = 0;

                MessageBox.Show(string.Format($"{chybi} tun chybí"));
            }

        }

        public override string ToString()
        {
            return string.Format($"Nákladní auto {spz} má nosnost {nosnost}t a má naloženo {HmotnostNakladu}t");
        }
    }
}
