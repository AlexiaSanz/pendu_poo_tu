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

        [Fact]
        public void LettreJouee ()
        {
            Mot motChat = new Mot("chat");

            Partie partie = new Partie(motChat);
            partie.Jouer('a');
            partie.Jouer('b');
            partie.LettresJouees.Should().HaveCount(2);
            partie.LettresJouees.Should().Contain('a');
            partie.LettresJouees.Should().Contain('b');
        }

        [Fact]
        public void MauvaiseLettreDejaJouee ()
        {
            Partie partie = new PartieBuilder().AvecMot("chat").Build();
            partie.Jouer('a');
            partie.Jouer ('b');
            partie.ViesRestantes.Should().Be(5);
            partie.Jouer ('b');
            partie.ViesRestantes.Should().Be(5);

            partie.LettresJouees.Should().HaveCount(2);
            partie.LettresJouees.Should().Contain('a');
            partie.LettresJouees.Should().Contain('b');
        }
    }
}
