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
                string userAnswer = Console.ReadLine();
                DaysoftheWeek day = (DaysoftheWeek)Enum.Parse(typeof(DaysoftheWeek),userAnswer, true);
                Console.WriteLine("Today is " + userAnswer);
                if (Enum.IsDefined(typeof(DaysoftheWeek), day) | day.ToString().Contains(","))
                {
                    Console.WriteLine(userAnswer, day.ToString());
                }                                  
                else
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }                                  

            catch (Exception)
            {
                Console.WriteLine("Please enter actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }                                                  
        }
    }
}
