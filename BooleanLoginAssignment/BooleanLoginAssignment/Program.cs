using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLoginAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Title
            Console.WriteLine("Basic Approval Program for Car Insurance: ");
            //Questions
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?");
            bool personDui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int personTickets = Convert.ToInt32(Console.Read());
            bool qualifications = (age > 15 && personDui == false && personTickets <= 3);

            //Qualifications
            Console.WriteLine("Qualified? " + qualifications);
            Console.ReadLine();
            





        }
    }
}
