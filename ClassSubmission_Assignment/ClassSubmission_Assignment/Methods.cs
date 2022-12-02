using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission_Assignment
{
    public class Methods
    {
        public void MathMethod1(int num1, int num2)
        {
            int result = num1 / 2;
            int result2 = num2 / 2;
            Console.WriteLine("Your number divided by 2 = " + result2);

        }

        public void MathMethod2(int num3, int num4)
        {
            int result5 = num3 * num4;
            Console.WriteLine(num3 + " x " + num4 + " = " + result5);
        }

        public static int MathMethod2(int num1, out int num2)
        {
            num2 = num1 + 5;
            return num2;
        }
    }
}
