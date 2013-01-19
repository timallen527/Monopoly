using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Game
    {
        private IRoundManager roundManager;
        public IEnumerable<Player> players { get; private set; }

        public Game(IRoundManager roundManager, IEnumerable<Player> players)
        {
            this.roundManager = roundManager;
            this.players = players;
        }

        public void PlayGame()
        {
            VerifyPlayers();
            RandomizePlayerOrder();

            while (players.Count(x => x.Enabled) > 1)
                roundManager.PlayRound(players);
        }

        private void RandomizePlayerOrder()
        {
            players = players.OrderBy(x => Guid.NewGuid());
        }

        private void VerifyPlayers()
        {
            if (players.Count() < 2 || players.Count() > 8)
                throw new InvalidOperationException();
        }

        public void PlayNumberOfRounds(Int32 numberOfRounds)
        {
            VerifyPlayers();
            RandomizePlayerOrder();

            for (Int32 i = 0; i < numberOfRounds; i++)
                roundManager.PlayRound(players);
        }
    }
}
