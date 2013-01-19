using System;
using System.Collections.Generic;

namespace Monopoly
{
    public interface IRoundManager
    {
        void PlayRound(IEnumerable<IPlayer> players);
        void PlayRounds(Int32 numberOfrounds, IEnumerable<IPlayer> players);
    }
}
