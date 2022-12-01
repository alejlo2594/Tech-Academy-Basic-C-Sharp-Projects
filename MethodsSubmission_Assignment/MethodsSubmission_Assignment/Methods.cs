using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsSubmission_Assignment
{
    class Methods
    {
        public int MathMethod(int number)
        {
            return number  + 10;
        }

        public decimal MathMethod (decimal number)
        {
            int decNumber = Convert.ToInt32(number);
            return decNumber * 5;
        }

        public int MathMethod(string number)
        {
            int stringNumber = Convert.ToInt32(number);
            return stringNumber / 5;
        }
    }
}

                                                                                           