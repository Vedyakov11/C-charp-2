using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Redactor redactor = new Redactor();
            redactor.ChooseDocument("file.txt");

            redactor.Open();
            redactor.Change();
            redactor.Save();

            Console.ReadKey();
        }
    }
}
