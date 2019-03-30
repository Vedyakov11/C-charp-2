using System;

namespace Lesson_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую сторону прямоугольника ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите вторую сторону прямоугольника ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(new string('-', 30));

            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Периметр = {0}, Площадь = {1}", rectangle.Perimeter, rectangle.Area);

            Console.ReadKey();
        }
    }
}
