using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monopoly
{
    public class Board : Monopoly.IBoard
    {
        public IEnumerable<BoardLocation> Locations { get; private set; }

        public Board(IEnumerable<BoardLocation> locations)
        {
            Locations = locations;
        }
    }
}
