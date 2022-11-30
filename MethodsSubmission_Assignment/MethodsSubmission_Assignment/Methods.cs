using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsSubmission_Assignment
{
    class Methods
    {
        public int MathMethod(int num1)
        {
            int num1Result = num1 + 10;
            return num1Result;
        }

        public decimal MathMethod(int num1, decimal num2)
        {
            decimal num2Result = num2 * 10;
            return num2Result;
        }

        public int MathMethod(int num1, decimal num2, string num3)
        {
            int num4 = Convert.ToInt32(num3);
            int num3Result = num4 - 10;
            return num3Result;
        }
    }
}

                                                                                           