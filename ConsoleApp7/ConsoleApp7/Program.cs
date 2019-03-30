using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress adress = new Adress();

            adress.Index = "169430";
            adress.Country = "Russia";
            adress.City = "Bely Bor";
            adress.Street = "Strelnikova";
            adress.House = "12";
            adress.Apartment = "3";

            Console.WriteLine(adress.Index);
            Console.WriteLine(adress.Country);
            Console.WriteLine(adress.City);
            Console.WriteLine(adress.Street);
            Console.WriteLine(adress.House);
            Console.WriteLine(adress.Apartment);

            Console.ReadKey();
        }
    }
}
