using System;

namespace Lesson_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(678904, "Alex", "Foxtrot") { Article = "Laptop", Quantity = 6 };

            invoice.CostCalculation(true);
            invoice.CostCalculation(false);

            Console.ReadKey();
        }
    }
}
