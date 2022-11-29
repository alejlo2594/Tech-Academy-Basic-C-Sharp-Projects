using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsSubmission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            var userValue = Convert.ToInt32(Console.ReadLine());

            var operatorObject = new Methods();
            var result = operatorObject.Add(userValue, 10);
            var result2 = operatorObject.Subtract(userValue, 2);
            var result3 = operatorObject.Multiply(userValue, 15);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadLine();
        }                                                
     }
 }
 
   
