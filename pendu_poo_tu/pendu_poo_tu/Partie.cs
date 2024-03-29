﻿using System;
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
        public bool Gagnee
        {
            get
            { 
                return this._mot.CompletAvec(LettresJouees); 
            }
        }
        public bool Perdu
        {
            get
            {
                return (this.ViesRestantes == 0);
            }
        }
        public string EvolutionMot
        {
            get
            {
                return this._mot.EvolutionMot(this.LettresJouees);
            }
        }
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
