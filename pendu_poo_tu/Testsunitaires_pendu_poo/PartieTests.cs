using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using pendu_poo_tu;

namespace Testsunitaires_pendu_poo
{
    
    public class PartieTests
    {
        [Fact]
        public void CommencerPartie ()
        {
            Mot motChat = new Mot("chat");

            Partie partie = new Partie(motChat);
            partie.ViesRestantes.Should().Be(6);
        }

        [Fact]
        public void BonneLettre ()
        {
            Mot motChat = new Mot("chat");

            Partie partie = new Partie(motChat);
            partie.Jouer('c');
            partie.ViesRestantes.Should().Be(6);
        }

        [Fact]
        public void MauvaiseLettre ()
        {
            Mot motChat = new Mot("chat");

            Partie partie = new Partie (motChat);
            partie.Jouer('b');
            partie.ViesRestantes.Should().Be(5);
        }
    }
}
