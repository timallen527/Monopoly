using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class RoundManager : Monopoly.IRoundManager
    {
        ITurnManager turnManager;

        public RoundManager(ITurnManager turnManager)
        {
            this.turnManager = turnManager;
        }

        public void PlayRound(IEnumerable<IPlayer> players)
        {
            foreach (var player in players)
                turnManager.PlayTurn(player);
        }
        
        public void PlayRounds(int numberOfrounds, IEnumerable<IPlayer> players)
        {
            for (Int32 i = 0; i < numberOfrounds; i++)
            {
                foreach (var player in players)
                    turnManager.PlayTurn(player);
            }
        }
    }
}
