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

            Methods FirstOperation = new Methods();
            Methods SecondOperation = new Methods();
            Methods ThirdOperation = new Methods();
            Console.WriteLine(FirstOperation.MathMethod(10));
            Console.WriteLine(SecondOperation.MathMethod(5.5m));
            Console.WriteLine(ThirdOperation.MathMethod(str1));
            Console.ReadLine();





        }                                                
     }
 }
 
   
