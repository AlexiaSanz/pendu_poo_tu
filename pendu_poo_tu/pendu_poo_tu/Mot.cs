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

        public string EvolutionMot(List<char> lettresJouees)
        {
            char[] evolution = new char[this._mot.Length];
            for (int i = 0; i < this._mot.Length; i++)
            {
              if (lettresJouees.Contains(this._mot[i]))
                {
                    evolution[i] = this._mot[i];
                }
              else
                {
                    evolution[i] = '_';
                }
            }
            return new string(evolution);
        }

        public bool CompletAvec (List<char> lettresJouees)
        {
            foreach (char lettre in this._mot)
            {
                if (!lettresJouees.Contains(lettre))
                    return false;
            }
            return true;
        }
    }
}
