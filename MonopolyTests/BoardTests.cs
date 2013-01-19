using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class BoardTests
    {
        [TestMethod]
        public void BoardIsConstructedWithFortyLocations()
        {
            var locations = ConstructLocations(40);
            var board = new Board(locations);
            Assert.AreEqual(40, board.Locations.Count());
        }

        private IEnumerable<BoardLocation> ConstructLocations(Int32 numberOfLocations)
        {
            List<BoardLocation> locations = new List<BoardLocation>();

            for (Int32 i = 0; i < numberOfLocations; i++)
                locations.Add(new BoardLocation());

            return locations;
        }
    }
}
