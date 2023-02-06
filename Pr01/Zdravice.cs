using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr01
{
    internal class Zdravice
    {
        /// Text pozdravu
        public string text;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="jmeno"> Jméno zadané uživatelem </param>
        /// <returns> Pozdraví uživatele podle jména </returns>
        public string Pozdrav(string jmeno)
        {
            return String.Format("{0} {1}", text, jmeno);
        }
    }
}
