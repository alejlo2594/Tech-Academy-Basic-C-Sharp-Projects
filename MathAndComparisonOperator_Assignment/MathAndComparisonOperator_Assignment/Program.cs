using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening Title
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //Person 1
            Console.WriteLine("Person 1");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            Console.ReadLine();
            int person1Rate = 15;
            Console.WriteLine(person1Rate);
            Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            Console.ReadLine();
            int person1Hours = 40;
            Console.WriteLine(person1Hours);
            Console.ReadLine();

            //Person 2
            Console.WriteLine("Person 2");
            Console.ReadLine();
            Console.WriteLine("Hourly Rate?");
            Console.ReadLine();
            int person2Rate = 20;
            Console.WriteLine(person2Rate);
            Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            Console.ReadLine();
            int person2Hours = 40;
            Console.WriteLine(person2Hours);
            Console.ReadLine();

            //Annual Salary of Person 1
            Console.WriteLine("Annual Salary of Person 1: ");
            Console.ReadLine();
            int product1 = person1Rate * person1Hours * 52;
            Console.WriteLine(product1);
            Console.ReadLine();

            //Annual Salary of Person 2
            Console.WriteLine("Annual Salary of Person 2: ");
            Console.ReadLine();
            int product2 = person2Rate * person2Hours * 52;
            Console.WriteLine(product2);
            Console.ReadLine();

            //Last Question
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.ReadLine();
            bool isMore = product1 > product2;
            Console.WriteLine(isMore);
            Console.ReadLine();
        }
    }
}
