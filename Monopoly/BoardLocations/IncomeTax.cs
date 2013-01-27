using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monopoly.BoardLocationStategies;

namespace Monopoly.BoardLocations
{
    public class IncomeTax : IBoardLocation
    {
        private IBoardLocationStrategy strategy;

        public IncomeTax(IBoardLocationStrategy strategy)
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
