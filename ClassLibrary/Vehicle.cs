using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// A base class for all the vehicles.
    /// It contains 2 properties, LicensePlate and Date.
    /// It also contains 2 methods that must be implemented in the child classes: Price and VehicleType.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// The license plate of the vehicle.
        /// </summary>
        public string LicensePlate { get; set; }
        /// <summary>
        /// Date of passing the bridge.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// A method that returns the price of the ticket. It takes no parameters.
        /// </summary>
        /// <returns>a double value, the price of the ticket.</returns>
        public abstract double Price();
        /// <summary>
        /// A method that returns the type of the vehicle. It takes no parameters.
        /// </summary>
        /// <returns>a string value, the type of the vehicle. </returns>
        public abstract string VehicleType();   
    }
}
