using System;
using System.Collections.Generic;
using System.Text;

namespace Oresundbron
{
    class MC : ClassLibrary.Vehicle
    {
        public override double Price()
        {
            return 210;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }

        public double BroBizzDiscount(bool brobizz)
        {
            if (brobizz)
            {
                return 73;
            }

            return Price();
        }
    }
}
