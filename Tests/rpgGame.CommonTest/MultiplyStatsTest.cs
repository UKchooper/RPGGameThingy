using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace rpgGame.CommonTest
{
    [TestClass]
    public class MultiplyStatsTest
    {
        [TestMethod]
        public void ValidIntMultipler()
        {
            //-- Arrange
            var valueOne = 2;
            var valueTwo = 8;

            var expected = 16;
            
            //-- Act
            var actual = Helpers.MultiplyStats(valueOne, valueTwo);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidDoubleMultipler()
        {
            //-- Arrange
            var valueOne = 2;
            var valueTwo = 3.50;

            var expected = 7;

            //-- Act
            var actual = Helpers.MultiplyStats(valueOne, valueTwo);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
