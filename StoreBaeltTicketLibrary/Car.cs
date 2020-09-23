using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBaeltTicketLibrary
{
   public class Car : ClassLibrary.Vehicle
    {
        public override double Price()
        {
            if (Date.DayOfWeek == DayOfWeek.Sunday || Date.DayOfWeek == DayOfWeek.Saturday)
            {
                return 240 * 0.80;
            }
            return 240;
        }

        public override string VehicleType()
        {
            return "car";
        }
    }
}
