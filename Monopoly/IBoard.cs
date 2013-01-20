using System;
using System.Collections.Generic;

namespace Monopoly
{
    public interface IBoard
    {
        IEnumerable<IBoardLocation> Locations { get; }
    }
}
