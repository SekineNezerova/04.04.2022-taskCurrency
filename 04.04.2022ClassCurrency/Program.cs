using _04._04._2022ClassCurrency.Models;
using System;

namespace _04._04._2022ClassCurrency
{
    class Program
    {
        static void Main(string[] args)
        {
            AZN azn = new AZN(100);
            USD usd = azn;
           Console.WriteLine(usd.Amount);
            USD usd1 = new USD(250);
            AZN azn1 = usd1;
            Console.WriteLine(azn1.Amount);
            EURO euro = new EURO(100);
            AZN azn2 = euro;
            Console.WriteLine(azn2.Amount);
            USD usd2 = new USD(100);
            EURO euro1 = usd2;
            Console.WriteLine(euro1.Amount);
            EURO euro2 = new EURO(120);
            USD usd3 = euro2;
            Console.WriteLine(usd3.Amount);
            AZN azn3 = new AZN(190);
            EURO euro3 = azn3;
            Console.WriteLine(euro3.Amount);


            AZN aznV = new AZN(250);
            EURO euroV = new EURO(600);
            Console.WriteLine(aznV<euroV);


            AZN aznA = new AZN(500);
            USD usdV = new USD(400);
            Console.WriteLine(aznA<usdV);


            USD usdD = new USD(550);
            EURO euroY = new EURO(330);
            Console.WriteLine(usdD>euroY);




        }
    }
}
