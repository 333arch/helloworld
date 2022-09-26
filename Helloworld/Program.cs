using System;

namespace ConsoleApp1
{
    class Program
    {
        static void JobQuote(string Job)
        {
            if (Job == "Engineer")
            {
                Console.WriteLine("The engineer has been, and is, the maker of history.");
            }
            else if (Job == "Developer")
            {
                Console.WriteLine("Logical thinking, passion and perseverance is paint on your pallet");
            }
            else if (Job == "Analyst")
            {
                Console.WriteLine("Seeing what other people can't see gives you great vision");
            }
            else
            {
                Console.WriteLine("I'm sorry we can not find a quote for your job");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your job");
            string TempTing = Console.ReadLine();
            JobQuote(TempTing);
        }
    }
}