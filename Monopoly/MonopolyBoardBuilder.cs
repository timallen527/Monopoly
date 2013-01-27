using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Monopoly.BoardLocations;
using Monopoly.BoardLocationStategies;

namespace Monopoly
{
    public class MonopolyBoardBuilder
    {
        public static IBoard BuildMonopolyBoard()
        {
            var locations = new List<IBoardLocation>();
            locations.Add(new Go(new GoStrategy()));

            for (Int32 i = 0; i < 3; i++)
                locations.Add(new BoardLocation());

            locations.Add(new IncomeTax(new IncomeTaxStrategy()));

            for (Int32 i = 0; i < 25; i++)
                locations.Add(new BoardLocation());

            locations.Add(new GoToJail(new GoToJailStrategy()));

            for (Int32 i = 0; i < 7; i++)
                locations.Add(new BoardLocation());

            locations.Add(new LuxuryTax(new LuxuryTaxStrategy()));
            locations.Add(new BoardLocation());

            return new Board(locations);
        }
    }
}
