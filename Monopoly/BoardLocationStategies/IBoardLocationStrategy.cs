using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly.BoardLocationStategies
{
    public interface IBoardLocationStrategy
    {
        void AffectPlayer(IPlayer player);
    }
}
