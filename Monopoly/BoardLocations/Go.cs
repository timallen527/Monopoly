using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monopoly.BoardLocationStategies;

namespace Monopoly.BoardLocations
{
    public class Go : IBoardLocation
    {
        private IBoardLocationStrategy strategy;

        public Go(IBoardLocationStrategy strategy)
        {
            this.strategy = strategy;
        }
        public void LandedOn(IPlayer player)
        {
            strategy.AffectPlayer(player);
        }

        public void PassedBy(IPlayer player)
        {
            strategy.AffectPlayer(player);
        }
    }
}
