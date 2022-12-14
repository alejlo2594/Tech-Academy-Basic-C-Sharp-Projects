using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 }; 
            try
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine("Pick a number.");
                    int numberOne = Convert.ToInt32(Console.ReadLine());
                    numbers[i] = numbers[i] / numberOne;
                    Console.WriteLine(numbers[i]);
                }
                
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

            
        }
    }
}
