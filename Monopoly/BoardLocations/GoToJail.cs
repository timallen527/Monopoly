using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monopoly.BoardLocationStategies;

namespace Monopoly.BoardLocations
{
    public class GoToJail : IBoardLocation
    {
        private IBoardLocationStrategy strategy;

        public GoToJail(IBoardLocationStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void LandedOn(IPlayer player)
        {
            strategy.AffectPlayer(player);
        }

        public void PassedBy(IPlayer player)
        {
        }
    }
}
