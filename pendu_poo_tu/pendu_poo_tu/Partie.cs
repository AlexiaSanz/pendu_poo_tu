using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pendu_poo_tu
{
    public class Partie 
    {
        private Mot _mot;
        public int ViesRestantes { get; private set; }

        public Partie (Mot mot)
        {
            this._mot = mot;
            ViesRestantes = 6;
        }
    }
}
