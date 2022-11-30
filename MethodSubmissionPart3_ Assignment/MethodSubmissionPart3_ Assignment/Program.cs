using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionPart3__Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number. Number entry not required");
            string answer = Console.ReadLine();

            Methods Operator = new Methods();

            Console.WriteLine("Your entered numbers + 15 = " + Operator.NewMethod (num1, answer));

            Console.ReadLine();
        }
    }
}
