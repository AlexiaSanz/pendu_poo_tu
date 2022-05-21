using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pendu_poo_tu
{
    public class Mot
    {
        private string _mot;

        public Mot(string mot)
        {
            this._mot = mot;
        }

        public bool Contient(char lettre)
        {
            return this._mot.Contains(lettre);
        }
    }
}
