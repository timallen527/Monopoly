using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class RoundManagerTests
    {
        [TestMethod]
        public void PlayTwentyRoundsEachPlayerPlaysTwentyTurns()
        {
            var mockTurnManager = new Mock<ITurnManager>();

            var players = new List<IPlayer>();
            var horse = new Player("Horse");
            var car = new Player("Car");
            players.Add(horse);
            players.Add(car);

            var roundManager = new RoundManager(mockTurnManager.Object);

            for (var i = 0; i < 20; i++)
                roundManager.PlayRound(players);

            mockTurnManager.Verify(x => x.PlayTurn(horse), Times.Exactly(20));
            mockTurnManager.Verify(x => x.PlayTurn(car), Times.Exactly(20));
        }
    }
}
