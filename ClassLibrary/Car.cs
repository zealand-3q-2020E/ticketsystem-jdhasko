using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// This class represents a car. It has a LicensePlate and a Date property.
    /// It contains two methods. Price, and VehicleType.
    /// </summary>
    public class Car : Vehicle
    {


        /// <summary>
        /// A method that returns the price of the ticket. It takes no parameters. Declared in the parent class: Vehicle
        /// </summary>
        /// <returns>a double value, the price of the ticket.</returns>
        public override double Price() => 240;

        /// <summary>
        /// A method that returns the type of the vehicle. It takes no parameters. Declared in the parent class: Vehicle;
        /// </summary>
        /// <returns>a string value, the type of the vehicle. </returns>
        public override string VehicleType() => "Car";

    }
}
