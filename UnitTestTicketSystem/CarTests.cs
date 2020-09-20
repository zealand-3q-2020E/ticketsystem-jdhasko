using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTicketSystem
{
    [TestClass]
    public class CarTests
    {
        [DataTestMethod]
        [DataRow(228,true)]
        [DataRow(240, false)]
        public void PriceTest(double expectedPrice, bool brobizz)
        {
            //Arrange
            Vehicle car = new Car();
            //Act
            var actualPrice = car.Price();
            actualPrice = car.CheckBroBizzDiscount(actualPrice, brobizz);
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
