using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsSubmission_Assignment
{
    class Program
    {
        public enum DaysoftheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week.");
                string userDayoftheWeek = Console.ReadLine();

                if (Enum.TryParse(userDayoftheWeek, out DaysoftheWeek numDay))
                {
                    Console.WriteLine("Today is " + numDay);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

            
        }
    }
}
