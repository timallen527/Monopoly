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
    public class IncomeTaxStrategyTests
    {
        private IBoardLocationStrategy strategy;

        [TestInitialize]
        public void Initialize()
        {
            this.strategy = new IncomeTaxStrategy();
        }

        [TestMethod]
        public void PlayerWithLessThan2000()
        {
            IPlayer player = new Player("Horse");
            player.Cash = 1800;

            strategy.AffectPlayer(player);

            Assert.AreEqual(1620, player.Cash);
        }

        [TestMethod]
        public void PlayerWith2000()
        {
            IPlayer player = new Player("Horse");
            player.Cash = 2000;

            strategy.AffectPlayer(player);

            Assert.AreEqual(1800, player.Cash);
        }

        [TestMethod]
        public void PlayerWithMoreThan2000()
        {
            IPlayer player = new Player("Horse");
            player.Cash = 2200;

            strategy.AffectPlayer(player);

            Assert.AreEqual(2000, player.Cash);
        }
    }
}
