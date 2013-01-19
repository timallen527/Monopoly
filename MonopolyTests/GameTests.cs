using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Moq;

namespace MonopolyTests
{
    [TestClass]
    public class GameTests
    {
        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void LessThanTwoPlayersThrowsException()
        {
            Mock<IRoundManager> mockRoundManager = new Mock<IRoundManager>();
            var car = new Player("Car");
            var players = new List<Player>() { car };
            var game = new Game(mockRoundManager.Object, players);

            game.PlayGame();
        }

        [TestMethod, ExpectedException(typeof(InvalidOperationException))]
        public void MoreThanEightPlayersThrowsException()
        {
            Mock<IRoundManager> mockRoundManager = new Mock<IRoundManager>();

            var car1 = new Player("Car");
            var car2 = new Player("Car");
            var car3 = new Player("Car");
            var car4 = new Player("Car");
            var car5 = new Player("Car");
            var car6 = new Player("Car");
            var car7 = new Player("Car");
            var car8 = new Player("Car");
            var car9 = new Player("Car");

            var players = new List<Player>() { car1, car2, car3, car4, car5, car6, car7, car8, car9 };

            var game = new Game(mockRoundManager.Object, players);

            game.PlayGame();
        }

        [TestMethod]
        public void PlayerOrderIsRandomized()
        {
            Mock<IRoundManager> mockRoundManager = new Mock<IRoundManager>();

            var car = new Player("Car");
            var horse = new Player( "Horse");
            var hat = new Player("Hat");
            var players = new List<Player>() { car, horse, hat };

            var game = new Game(mockRoundManager.Object, players);

            Boolean carIsFirst = false;
            Boolean horseIsFirst = false;
            Boolean hatIsFirst = false;

            for (Int32 i = 0; i < 100; i++)
            {
                game.PlayNumberOfRounds(1);

                if (game.players.First().Name == "Car")
                    carIsFirst = true;
                else if (game.players.First().Name == "Horse")
                    horseIsFirst = true;
                else if (game.players.First().Name == "Hat")
                    hatIsFirst = true;
            }

            Assert.IsTrue(carIsFirst && horseIsFirst && hatIsFirst);
        }
    }
}
