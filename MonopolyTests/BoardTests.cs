using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.BoardLocations;

namespace MonopolyTests
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void BoardIsConstructedWithFortyLocations()
        {
            var board = MonopolyBoardConstructor.BuildMonopolyBoard();
            Assert.AreEqual(40, board.Locations.Count());
        }

        private IEnumerable<IBoardLocation> ConstructLocations(Int32 numberOfLocations)
        {
            List<IBoardLocation> locations = new List<IBoardLocation>();

            for (Int32 i = 0; i < numberOfLocations; i++)
                locations.Add(new BoardLocation());

            return locations;
        }
    }
}
