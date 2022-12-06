using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Person = new Employee();
            Person.FirstName = ("Sample");
            Person.LastName = ("Student");
            Person.SayName();
            Console.ReadLine();

            IQuittable quitter = new Employee { FirstName = "John", LastName = " Doe" };
            quitter.Quit();
            Console.ReadLine();


        }
    }
}
