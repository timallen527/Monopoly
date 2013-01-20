using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly.BoardLocations
{
    public class Go : IBoardLocation
    {
        public void LandedOn(IPlayer player)
        {
            player.Cash += 200;
        }

        public void PassedBy(IPlayer player)
        {
            player.Cash += 200;
        }
    }
}
