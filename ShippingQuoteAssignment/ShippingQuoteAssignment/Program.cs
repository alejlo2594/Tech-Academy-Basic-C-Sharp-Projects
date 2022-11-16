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

            //Weight 
            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter package width below: ");
            }

            //Width
            int packageWidth = Convert.ToInt32(Console.ReadLine());
            if (packageWidth > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Please enter package height below: ");
            }

             //Height
            int packageHeight = Convert.ToInt32(Console.ReadLine());
            if ((packageHeight + packageWidth) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Please enter package length below: ");
            }

            //Length
            int packageLength = Convert.ToInt32(Console.ReadLine());
            if ((packageHeight + packageWidth + packageLength) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                Console.WriteLine("Your estimated total for shipping this package is: ");
            }

            //Calculate shipping quote
            int packageQuote = (packageWidth * packageHeight * packageLength) * packageWeight / 100;
            Console.WriteLine("$" + packageQuote + ".00");
            Console.WriteLine("Thank you!");

            Console.ReadLine();



        }
    }
}
