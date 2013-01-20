using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monopoly.BoardLocations;

namespace Monopoly
{
    public class MonopolyBoardConstructor
    {
        public static IBoard BuildMonopolyBoard()
        {
            var locations = new List<IBoardLocation>();
            locations.Add(new Go());

            for (Int32 i = 0; i < 3; i++)
                locations.Add(new BoardLocation());

            locations.Add(new IncomeTax());

            for (Int32 i = 0; i < 25; i++)
                locations.Add(new BoardLocation());

            locations.Add(new GoToJail());

            for (Int32 i = 0; i < 7; i++)
                locations.Add(new BoardLocation());

            locations.Add(new LuxuryTax());
            locations.Add(new BoardLocation());

            return new Board(locations);
        }
    }
}
