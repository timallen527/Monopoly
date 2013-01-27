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
    public class GoToJailStrategyTests
    {
        [TestMethod]
        public void PlayerGoToJail()
        {
            var strategy = new GoToJailStrategy();
            IPlayer player = new Player("Horse");

            strategy.AffectPlayer(player);

            Assert.AreEqual(10, player.Location);
        }
    }
}
