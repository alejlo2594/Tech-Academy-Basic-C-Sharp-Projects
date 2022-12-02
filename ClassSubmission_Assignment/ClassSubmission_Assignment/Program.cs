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
            int number3 = 100;
            int number4 = 7;

            Methods FirstOp = new Methods();
            FirstOp.MathMethodFirst(num1, num2);
            FirstOp.MathMethodSecond(number3, number4);

            Console.ReadLine();
        }
    }
}
