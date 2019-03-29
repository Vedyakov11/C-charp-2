using System;

namespace Lesson_2._3
{
    class Employee
    {
        int experience;
        string post;

        public string Surname { get; }
        public string Name { get; }
        public string Post
        {
            get
            {
                if (post == null)
                    return "Должность не известна";
                return post;
            }
            set
            {
                if (value != null)
                    post = value;
            }
        }

        public int Experience
        {
            get { return experience; }
            set
            {
                if (value >= 0)
                    experience = value;
            }
        }

        public Employee()
        {

        }

        public Employee(string surname, string name)
        {
            this.Surname = surname;
            this.Name = name;
        }

        public double CountSalary()
        {
            double salarykoef;

            switch(post.ToLower())
            {
                case "manager":
                    salarykoef = 200;
                    break;
                case "developer":
                    salarykoef = 150;
                    break;
                case "secretary":
                    salarykoef = 80;
                    break;
                case "cleaner":
                    salarykoef = 65;
                    break;
                default:
                    salarykoef = 100;
                    break;
            }
            switch(experience)
            {
                case 0:
                    salarykoef *= 1.5;
                    break;
                case 1:
                    salarykoef *= 2.0;
                    break;
                case 2:
                    salarykoef *= 2.5;
                    break;
                default:
                    salarykoef *= 5;
                    break;
            }
            return salarykoef;
        }

        public void ShowSalary()
        {
            Console.WriteLine("Зарплата {0}, подоходный налог {1}", CountSalary(), CountSalary() * 0.13);
        }
    }
}
