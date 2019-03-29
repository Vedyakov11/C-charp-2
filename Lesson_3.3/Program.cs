using System;

namespace Lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship = new Ship(20000, 120, 2000) { Passengers = 28, Port = "Севастополь" };

            Console.WriteLine("Цена коробля {0}, скорость {1}, год выпуска {2}, количество пассажиров {3}, порт приписки {4}",
                ship.Price, ship.Speed, ship.Year, ship.Passengers, ship.Port);

            Console.ReadKey();
        }
    }
}
