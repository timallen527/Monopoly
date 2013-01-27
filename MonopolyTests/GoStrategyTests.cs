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
    public class GoStrategyTests
    {
        [TestMethod]
        public void PlayerCollectsTwoHundredDollars()
        {
            var strategy = new GoStrategy();
            IPlayer player = new Player("Horse");
            strategy.AffectPlayer(player);

            Assert.AreEqual(200, player.Cash);
        }
    }
}
