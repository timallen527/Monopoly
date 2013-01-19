using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class TurnManager : Monopoly.ITurnManager
    {
        private IBoard board;
        private IEnumerable<IDie> dice;

        public TurnManager(IBoard board, IEnumerable<IDie> dice)
        {
            this.board = board;
            this.dice = dice;
        }

        public void PlayTurn(IPlayer player)
        {
            var rollValue = RollDice();
            MovePlayer(player, rollValue);
        }

        private void MovePlayer(IPlayer player, int rollValue)
        {
            if (player.Location + rollValue > board.Locations.Count())
                player.Location = (player.Location + rollValue) % board.Locations.Count();
            else
                player.Location += rollValue;
        }

        private Int32 RollDice()
        {
            Int32 rollValue = 0;

            foreach (var die in dice)
                rollValue += die.Roll();

            return rollValue;
        }
    }
}
