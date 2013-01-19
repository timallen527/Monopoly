using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class TurnManagerTests
    {
        private IBoard board;
        private List<IDie> dice;

        [TestInitialize]
        public void Initialize()
        {
            dice = new List<IDie>();
            dice.Add(new LoadedDie(3));
            dice.Add(new LoadedDie(4));

            List<BoardLocation> locations = new List<BoardLocation>();

            for (Int32 i = 0; i < 40; i++)
                locations.Add(new BoardLocation());

            board = new Board(locations);
        }

        [TestMethod]
        public void PlayerStartsAtZeroAndRollsASevenDude()
        {            
            IPlayer player = new Player("Horse");
            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(7, player.Location);
        }

        [TestMethod]
        public void PlayerStartsAtThirtyNineAndRollsASevenDude()
        {
            IPlayer player = new Player("Horse");
            player.Location = 39;
            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(6, player.Location);
        }
    }
}
