using System;

namespace ConsoleApp1
{
    class Program
    {
        static void CurrencyConv(double GBP, string Currency)
        {
            if (Currency == "Euro")
            {
                double Total = (GBP * 1.12);
                Console.WriteLine(Total);
            }
            else if (Currency == "USD")
            {
                double Total = (GBP * 1.08);
                Console.WriteLine(Total);
            }
            else if (Currency == "Yuan")
            {
                double Total = (GBP * 7.62);
                Console.WriteLine(Total);
            }
            else if (Currency == "Yen")
            {
                double Total = (GBP * 154.34);
                Console.WriteLine(Total);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How much GBP?");
            double GBP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("To what currency");
            string Currency = Console.ReadLine();
            CurrencyConv(GBP, Currency);
        }
    }
}
