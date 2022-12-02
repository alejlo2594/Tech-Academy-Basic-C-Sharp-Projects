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
            string num2 = Console.ReadLine();

            Methods Operator = new Methods();
            int result = 0;

            if (num2 == "")
            {
                result = Operator.NewMethod(num1);

            }
            else
            {
                int number2 = Convert.ToInt32(num2);
                result = Operator.NewMethod(num1, number2);
            }

            Console.WriteLine("Result:  " + result);

            Console.ReadLine(); 
        }
    }
}
