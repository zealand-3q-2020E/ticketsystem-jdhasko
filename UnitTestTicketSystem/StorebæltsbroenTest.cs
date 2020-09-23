using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using Storebæltsbroen;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTicketSystem
{
    [TestClass]
    public class StorebæltsbroenTest
    {

        [DataTestMethod]
        [DataRow( true, 182.4)]
        public void WeekendDiscountTest(bool brobizz, double expectedPrice)
        {
            //Arrange
            Car car = new Car();
            car.Date = new DateTime(2020,09,19);
            //Act
            var actualPrice = car.CheckBroBizzDiscount(car.Price(), brobizz);

            //Assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }
    }
}
