using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTicketSystem
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void PriceTest()
        {
            //Arrange
            Car car = new Car();
            //Act
            var actualPrice = car.Price();
            double expectedPrice = 240;
            //Assert
            Assert.AreEqual(expectedPrice,actualPrice);
        }

        [TestMethod]
        public void VehicleTypeTest()
        {
            //Arrange
            Car car = new Car();
            //Act
            var actualOutput = car.VehicleType();
            string expectedOutput = "Car";
            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }

    }
}
