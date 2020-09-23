using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public class PiceConverterService
    {
        public double ExchangeMoneyFromDK(double exchangeRate, double amount)
        {

            return  Math.Round(  amount * exchangeRate);
        }


        public enum Currency
        {
            DKK,
            HUF,
            EUR,
            SEK
        }
    }
}
