using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTicketSystem
{
    [TestClass]
    public class CarTests
    {
        [DataTestMethod]
        [DataRow(228,240,true)]
        [DataRow(300, 300, false)]
        [DataRow(475, 500, true)]
        public void PriceTest(double expectedPrice, double defaultPrice, bool brobizz)
        {
            //Arrange
            Vehicle car = new Car();
            //Act
            var actualPrice = car.Price(defaultPrice,brobizz);
            //Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        [TestMethod]
        public void VehicleTypeTest()
        {
            //Arrange
            Vehicle car = new Car();
            //Act
            var actualOutput = car.VehicleType();
            string expectedOutput = "Car";
            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [DataTestMethod]
        [DataRow("23BLLL679")]
        [DataRow("ABC3242D123")]
        [DataRow("4234232346623")]
        [DataRow("A43244BCDF")]
        [DataRow("LK3")]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckLicensePlateLengthException(string insertedLP)
        {
            //Arrange
            Vehicle car1 = new Car();

            //Act
            var result = car1.CheckLicensePlateLength(insertedLP);

            //Assert
            Assert.IsFalse(result);
        }

        [DataTestMethod]
        [DataRow("23B354")]
        [DataRow("LKH655")]
        [DataRow("MAMA111")]
        [DataRow("D1LK56")] 
        public void CheckCorrectLicensePlate(string insertedLP)
        {

            //Arrange
            Vehicle car1 = new Car();

            //Act
            var result = car1.CheckLicensePlateLength(insertedLP);

            //Assert
            Assert.IsTrue(result);
        }



    }
}
