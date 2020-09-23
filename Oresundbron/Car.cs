using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Xml.Serialization;

namespace Oresundbron 
{
    public class Car : ClassLibrary.Car
    {
        public override double Price()
        {
            
            return 410;
        }

        public override string VehicleType()
        {
            return "Oresund Car";
        }

        public double BroBizzDiscount(bool brobizz)
        {
            if (brobizz)
            {
                return 161;
            }

            return Price();
        }

    }
}
