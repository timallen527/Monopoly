using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly.BoardLocationStategies
{
    public class GoToJailStrategy : IBoardLocationStrategy
    {
        public void AffectPlayer(IPlayer player)
        {
            player.Location = 10;
        }
    }
}
