using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(8.56, 10.14, 0.12);

            converter.ToUsd(120);
            converter.FromUsd(120);
            converter.ToEur(100);
            converter.FromEur(100);
            converter.ToRub(150);
            converter.FromRub(150);

            Console.ReadKey();
        }
    }
}
