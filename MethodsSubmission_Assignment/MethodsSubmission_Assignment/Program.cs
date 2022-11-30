using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsSubmission_Assignment
{
    class Program
    {
        public static int Data { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int num1 = 10;
            decimal num2 = 5.5m;
            string str1 = "15";
            int num3 = Int32.Parse(str1);

            Methods FirstOp = new Methods();
            Methods SecondOp = new Methods();
            Methods ThirdOp = new Methods();
            Console.WriteLine(FirstOp.MathMethod(10));
            Console.WriteLine(SecondOp.MathMethod(10, 5.5m));
            Console.WriteLine(ThirdOp.MathMethod(10, 5.5m, str1));
            Console.ReadLine();





        }                                                
     }
 }
 
   
