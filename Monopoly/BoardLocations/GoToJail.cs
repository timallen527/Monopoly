using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly.BoardLocations
{
    public class GoToJail : IBoardLocation
    {
        public void LandedOn(IPlayer player)
        {
            player.Location = 10;
        }

        public void PassedBy(IPlayer player)
        {
        }
    }
}
