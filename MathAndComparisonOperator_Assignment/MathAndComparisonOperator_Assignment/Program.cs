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
            Console.WriteLine("Hourly Rate?");
            int person1Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person1Hours = Convert.ToInt32(Console.ReadLine());

            //Person 2
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int person2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int person2Hours = Convert.ToInt32(Console.ReadLine());

            //Annual Salary of Person 1
            string annualSalary1 = Convert.ToString(person1Rate * person1Hours * 52);
            Console.WriteLine("Annual Salary of Person 1: " + annualSalary1);


            //Annual Salary of Person 2
            string annualSalary2 = Convert.ToString(person2Rate * person2Hours * 52);
            Console.WriteLine("Annual Salary of Person 2: " + annualSalary2);

            //Last Question
            bool compareP1AndP2 = Convert.ToInt32(annualSalary1) > Convert.ToInt32(annualSalary2); 
            Console.WriteLine("Does Person 1 make more money than Person 2? " + compareP1AndP2);
            Console.ReadLine();
        }
    }
}
