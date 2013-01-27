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
    public class MonopolyBoardBuilderTests
    {
        [TestMethod]
        public void BoardIsConstructedWithFortyLocations()
        {
            var board = MonopolyBoardBuilder.BuildMonopolyBoard();
            Assert.AreEqual(40, board.Locations.Count());
        }
    }
}
