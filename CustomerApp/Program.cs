using System;
using ClassLibrary;

namespace CustomerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Write("Enter your license plate number> ");
                var licenseplate = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Please choose a currency:");
                Console.WriteLine(" 1) " + PiceConverterService.Currency.DKK);
                Console.WriteLine(" 2) " + PiceConverterService.Currency.HUF);
                Console.WriteLine(" 3) " + PiceConverterService.Currency.SEK);
                Console.WriteLine(" 4) " + PiceConverterService.Currency.EUR);

                Console.Write( " > " );



                Console.WriteLine("Please choose a bridge you would like to pass\n\n\t\t1) Oresundbron\n\t\t2) Storebæltsbroen");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                    {

                        break;
                    }
                }
            }
        }




    }
}
