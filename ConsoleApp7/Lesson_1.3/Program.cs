using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "Реализуйте возможность добавления в книгу названия книги, имени автора и содержания." +
                "Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и содержание.";

            Book book = new Book("metodichka", "Home", content);
            book.Show();

            Console.ReadKey();
        }
    }
}
