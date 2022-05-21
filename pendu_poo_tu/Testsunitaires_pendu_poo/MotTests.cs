using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using pendu_poo_tu;
using Xunit;

namespace Testsunitaires_pendu_poo
{
    public class MotTests
    {
        [Fact]
        public void MotContientLettre()
        {
            var motChat = new Mot("chat");
            bool contient_c = motChat.Contient('c');
            contient_c.Should().BeTrue();
        }
    }
}
