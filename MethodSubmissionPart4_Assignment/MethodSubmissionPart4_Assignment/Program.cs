﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionPart4_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Methods Operator = new Methods();
            Operator.NewMethod(num1, num2);

            Console.ReadLine();
        }
    }
}