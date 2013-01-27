using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.BoardLocationStategies;

namespace MonopolyTests
{
    [TestClass]
    public class LuxuryTaxStrategyTests
    {
        [TestMethod]
        public void PlayerLandsOnLuxuryTax()
        {
            var strategy = new LuxuryTaxStrategy();
            var player = new Player("Horse");

            player.Cash = 2000;

            strategy.AffectPlayer(player);

            Assert.AreEqual(1925, player.Cash);
        }
    }
}
