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
        /// A method that returns the price of the ticket. Takes 2 parameters, the basic price of the ticket
        /// and a boolen value if brobizz was used or not.
        /// </summary>
        /// <returns>a double value, the price of the ticket.</returns>
        public abstract double Price();
        /// <summary>
        /// A method that returns the type of the vehicle. It takes no parameters.
        /// </summary>
        /// <returns>a string value, the type of the vehicle. </returns>
        public abstract string VehicleType();

        /// <summary>
        /// Method that checks the length of the License Plate
        /// </summary>
        /// <param name="insertedLicensePlate"></param>
        /// <returns>Returns a true value if the license plate is correct.</returns>
        public virtual bool CheckLicensePlateLength(string insertedLicensePlate)
        {
            if (insertedLicensePlate.Length >7)
            {
                throw new ArgumentException("The inserted License Plate is too long.");
            }

            else if (insertedLicensePlate.Length>3)
            {
                return true;

            }
            throw new ArgumentException("The inserted License Plate is too short.");
        }

        /// <summary>
        /// Method that checks if it's possible to give BroBizzDiscount.
        /// if it is returns the discounted price
        /// </summary>
        /// <param name="defaultPrice"></param>
        /// <param name="brobizz"></param>
        /// <returns>returns a double value</returns>
        public double CheckBroBizzDiscount(double defaultPrice, bool brobizz)
        {
            if (brobizz == true)
            {
                return Math.Round(defaultPrice * 0.95, 2);
            }

            return defaultPrice;
        }
    }
}
