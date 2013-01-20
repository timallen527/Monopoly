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
            for (Int32 i = 0; i < rollValue - 1; i++)
                PassByLocation(player);
            
            LandOnLocation(player);
        }

        private void PassByLocation(IPlayer player)
        {
            player.Location = (player.Location + 1) % board.Locations.Count();
            var location = board.Locations.ToList()[player.Location];

            location.PassedBy(player);
        }

        private void LandOnLocation(IPlayer player)
        {
            player.Location = (player.Location + 1) % board.Locations.Count();
            var location = board.Locations.ToList()[player.Location];

            location.LandedOn(player);
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
