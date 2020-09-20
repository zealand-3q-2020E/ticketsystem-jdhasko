using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// This class represents a MotorCycle. It has a LicencePlate and a Date property and a Price and a Type method.
    /// </summary>
    public class MC : Vehicle
    {


        /// <summary>
        /// A method that returns the type of the vehicle. It takes no parameters.
        /// </summary>
        /// <returns>a string value, the type of the vehicle. </returns>
        public override string VehicleType() => "MC";
    }
}
