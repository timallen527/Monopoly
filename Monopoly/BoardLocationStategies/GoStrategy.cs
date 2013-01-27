﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly.BoardLocationStategies
{
    public class GoStrategy : IBoardLocationStrategy
    {
        public void AffectPlayer(IPlayer player)
        {
            player.Cash += 200;
        }
    }
}
