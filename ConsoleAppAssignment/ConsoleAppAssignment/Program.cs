using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 25;

            while (!isGuessed)
            {
                switch (number)
                {
                    case 15:
                        Console.WriteLine("You guessed 15. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("You guessed 10. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 40:
                        Console.WriteLine("You guessed 40. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 25:
                        Console.WriteLine("You guessed the number 25. That is correct!");
                        isGuessed = true;
                        break;
                }
            }


            do 
            {
                switch (number)
                {
                    case 15:
                        Console.WriteLine("You guessed 15. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 10:
                        Console.WriteLine("You guessed 10. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 40:
                        Console.WriteLine("You guessed 40. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 25:
                        Console.WriteLine("You guessed the number 25. That is correct!");
                        isGuessed = true;
                        break;
                }
             }
            
            while (!isGuessed);

            Console.Read();

        }
    }   
}
