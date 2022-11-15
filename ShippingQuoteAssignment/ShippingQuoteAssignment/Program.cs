using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening Title
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            //User must enter package weight
            Console.WriteLine("Please enter package weight: ");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            string weight = packageWeight < 50 ? "Please enter package width below: " : "Package too heavy to be shipped via Package Express. Have a good day.";
            Console.WriteLine(weight);

            //User must enter width and height of package
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package height below: ");
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter package length below: ");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            //Add dimensions
            if ((packageWidth + packageHeight + packageLength) < 50) 
            {
                Console.WriteLine("Your estimated total for shipping this package is: ");
            }
            else
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
                    
            //Calculate shipping quote
            int packageQuote = (packageWidth * packageHeight * packageLength) * packageWeight / 100;
            Console.WriteLine("$" + packageQuote + ".00");
            Console.WriteLine("Thank you!");

            Console.ReadLine();



        }
    }
}
