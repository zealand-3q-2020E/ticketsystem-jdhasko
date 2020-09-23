using System;
using System.Collections.Generic;
using System.Text;

namespace Storebæltsbroen
{
    public class Car : ClassLibrary.Car
    {
        public override double Price()
        {
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                return 240 * 0.8;
            }

            return 240;
        }
    }
}
