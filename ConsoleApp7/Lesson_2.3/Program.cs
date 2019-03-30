using System;

namespace Lesson_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Smit", "Petr");
            employee.Post = "manager";
            employee.Experience = 1;

            Console.WriteLine(employee.Surname + " " + employee.Name + " " + employee.Post.ToUpper());
            employee.ShowSalary();

            Console.ReadKey();
        }
    }
}
