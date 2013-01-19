using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;

namespace MonopolyTests
{
    [TestClass]
    public class DieTests
    {
        [TestMethod]
        public void DieIsRandomBetweenOneAndSix()
        {
            var die = new Die();
            Boolean[] values = new Boolean[6];

            for (Int32 i = 0; i < 100; i++)
            {
                die.Roll();
                values[die.GetValue() - 1] = true;
            }

            foreach (var value in values)
            {
                Assert.IsTrue(value);
            }
        }
    }
}
