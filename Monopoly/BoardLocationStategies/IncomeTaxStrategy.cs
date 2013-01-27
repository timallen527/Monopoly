using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly.BoardLocationStategies
{
    public class IncomeTaxStrategy : IBoardLocationStrategy
    {
        public void AffectPlayer(IPlayer player)
        {
            if (player.Cash < 2001)
                player.Cash = Convert.ToInt32(player.Cash * 0.9);
            else
                player.Cash = player.Cash - 200;
        }
    }
}
