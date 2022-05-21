using pendu_poo_tu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testsunitaires_pendu_poo
{
    internal class PartieBuilder
    {
        private string _mot = "chat";

        public PartieBuilder AvecMot(string mot)
        {
            this._mot = mot;
            return this;
        }

        public Partie Build()
        {
            var mot = new Mot(this._mot);
            return new Partie(mot);
        }
    }
}
