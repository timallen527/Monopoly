using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.BoardLocations;

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

            board = MonopolyBoardConstructor.BuildMonopolyBoard();
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

        [TestMethod]
        public void PlayerOnLocationThirtyThreeRollsSevenEndsOnLocationZero()
        {
            IPlayer player = new Player("Horse");
            player.Location = 33;
            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(0, player.Location);
        }

        [TestMethod]
        public void PlayerLandsOnGoCollectsTwoHundredDollars()
        {
            IPlayer player = new Player("Horse");
            player.Location = 33;
            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(200, player.Cash);
        }

        [TestMethod]
        public void PlayerPassesGoCollectsTwoHundredDollars()
        {
            IPlayer player = new Player("Horse");
            player.Location = 34;
            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(200, player.Cash);
        }
        
        [TestMethod]
        public void PlayerStartssOnGoDoesNotCollectTwoHundredDollars()
        {
            IPlayer player = new Player("Horse");
            player.Location = 33;
            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(0, player.Cash);
        }

        [TestMethod]
        public void PlayerLandsOnGoToJail()
        {
            IPlayer player = new Player("Horse");
            player.Location = 23;
            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(10, player.Location);
        }

        [TestMethod]
        public void PlayerPassesByGoToJail()
        {
            IPlayer player = new Player("Horse");
            player.Location = 24;
            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(31, player.Location);
        }

        [TestMethod]
        public void PlayerLandsOnIncomeTaxWithLessThan2000()
        {
            IPlayer player = new Player("Horse");
            player.Cash = 1800;
            player.Location = 1;

            var dice = new List<IDie>();
            dice.Add(new LoadedDie(1));
            dice.Add(new LoadedDie(2));

            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(1620, player.Cash);
        }

        [TestMethod]
        public void PlayerLandsOnIncomeTaxWith2000()
        {
            IPlayer player = new Player("Horse");
            player.Cash = 2000;
            player.Location = 1;

            var dice = new List<IDie>();
            dice.Add(new LoadedDie(1));
            dice.Add(new LoadedDie(2));

            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(1800, player.Cash);
        }

        [TestMethod]
        public void PlayerLandsOnIncomeTaxWithMoreThan2000()
        {
            IPlayer player = new Player("Horse");
            player.Cash = 2200;
            player.Location = 1;

            var dice = new List<IDie>();
            dice.Add(new LoadedDie(1));
            dice.Add(new LoadedDie(2));

            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(2000, player.Cash);
        }

        [TestMethod]
        public void PlayerPassesByIncomeTax()
        {
            IPlayer player = new Player("Horse");
            player.Cash = 2000;
            player.Location = 2;

            var dice = new List<IDie>();
            dice.Add(new LoadedDie(1));
            dice.Add(new LoadedDie(2));

            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(2000, player.Cash);
        }

        [TestMethod]
        public void PlayerLandsOnLuxuryTax()
        {
            IPlayer player = new Player("Horse");
            player.Cash = 2000;
            player.Location = 35;

            var dice = new List<IDie>();
            dice.Add(new LoadedDie(1));
            dice.Add(new LoadedDie(2));

            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(1925, player.Cash);
        }

        [TestMethod]
        public void PlayerPassesByLuxuryTax()
        {
            IPlayer player = new Player("Horse");
            player.Cash = 2000;
            player.Location = 36;

            var dice = new List<IDie>();
            dice.Add(new LoadedDie(1));
            dice.Add(new LoadedDie(2));

            var turnManager = new TurnManager(board, dice);

            turnManager.PlayTurn(player);

            Assert.AreEqual(2000, player.Cash);
        }
    }
}