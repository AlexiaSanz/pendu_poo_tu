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
        public List<char> LettresJouees { get; private init; }



        public Partie(Mot mot)
        {
            this._mot = mot;
            ViesRestantes = 6;
            LettresJouees = new List<char>();
        }

        public void Jouer(char Lettre)
        {
            if (LettresJouees.Contains(Lettre))
            {
                return;
            }

            this.LettresJouees.Add(Lettre);

            if (!this._mot.Contient(Lettre))
            {
                this.ViesRestantes--;
            }

        }
    }
}
