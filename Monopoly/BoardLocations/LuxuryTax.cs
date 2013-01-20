using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly.BoardLocations
{
    public class LuxuryTax : IBoardLocation
    {
        public void LandedOn(IPlayer player)
        {
            player.Cash = player.Cash - 75;
        }

        public void PassedBy(IPlayer player)
        {
        }
    }
}
