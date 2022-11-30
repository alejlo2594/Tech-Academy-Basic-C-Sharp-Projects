using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num1 = 10;
            

            Methods Operator = new Methods();
            Operator.(num1, num2);

            Console.ReadLine();
        }
    }
}
