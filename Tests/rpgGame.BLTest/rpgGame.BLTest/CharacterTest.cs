using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rpgGame.BL;

namespace rpgGame.BLTest
{
    [TestClass]
    public class CharacterTest
    {
        [TestMethod]
        public void ValidNameAddDescription()
        {
            //-- Arrange
            Character name = new Character(); 

            var source = "Archer";
            var expected = $"You have selected the Archer. His range attacks are powerful!";

            //-- Act
            var actual = name.AddDescription(source);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidNameAddDescription()
        {
            //-- Arrange
            Character name = new Character();

            var source = "NOTAREALPERSONINTHEGAMEO";
            var expected = $"That's not a character!";

            //-- Act
            var actual = name.AddDescription(source);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidNameConfirmSelect()
        {
            //-- Arrange
            Character name = new Character();

            var source = "Archer";
            var expected = $"Are you sure you want the Archer?";

            //-- Act
            var actual = name.ConfirmSelect(source);

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
