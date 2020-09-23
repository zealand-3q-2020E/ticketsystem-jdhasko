using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace ClassLibrary
{
    public class Trip
    {
        public Car Car { get; set; }
        public string Bridge { get; set; }
        public PiceConverterService.Currency currency;
    }
}
