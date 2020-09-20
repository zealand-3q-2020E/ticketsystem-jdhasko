using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTicketSystem
{
    [TestClass]
   public class MCTests
    {
        [TestMethod]
        public void PriceTest()
        {
            //Arrange
            MC motorC = new MC();
            //Act
            var actualPrice = motorC.Price();
            double expectedPrice = 125;
            //Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void VehicleTypeTest()
        {
            //Arrange
            MC motorC = new MC();
            //Act
            var actualOutput = motorC.VehicleType();
            string expectedOutput = "MC";
            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
