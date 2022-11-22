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
            //Part 1: 
            Console.WriteLine("Part 1: ");
            Console.WriteLine("Please type a word:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Please type a word:");
            string string2 = Console.ReadLine();
            Console.WriteLine("Please type a word:");
            string string3 = Console.ReadLine();
            Console.WriteLine("Please type a word:");
            string string4 = Console.ReadLine();
            Console.WriteLine("Please type a word:");
            string string5 = Console.ReadLine();
            Console.WriteLine("Please type a word:\n");
            string string6 = Console.ReadLine();
            string[] words = { string1, string2, string3, string4, string5, string6 };
            foreach (string word in words)
            {
                Console.WriteLine(word);
                Console.ReadLine();
            }


            //Part 2:
            Console.WriteLine("Part 2: ");
            Console.WriteLine("Please type a number");
            string Number = Console.ReadLine();
            int i = Convert.ToInt32(Number);
            while (i < 0)
            {
                i++;
                Console.Write("\t, " + i);

            }

            //Part 3:     

            Console.WriteLine("Part 3: ");
            Console.WriteLine("How many points do you have on your drivers license?");

            List<int> points = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int point in points)

            {
                if (point <= 10)
                {
                    Console.WriteLine("You have " + point + " you can keep your license ");
                }


                else
                {
                    Console.WriteLine("You have " + point + " or more points you have lost your license.");
                }
            }

            Console.ReadLine();

            Console.WriteLine("Welcome to Total Wine, before you can check out, I need to see your ID");


            List<int> ages = new List<int> { 18, 20, 21, 25, 32 };

            foreach (int age in ages)


            {
                if (age < 20)
                {
                    Console.WriteLine("You're " + age + " I'm sorry I can't sell you that");

                }
                else
                {
                    Console.WriteLine("You're " + age + " Thank you for your purchase");
                }

            }
            Console.ReadLine();

            //Part 4:
            List<string> cars = new List<string> { "Honda", "Toyota", "BMW", "Mercedes", "Fiat", "Kia", "Subaru"};
            Console.WriteLine("Select one of the following:  Honda, Toyota, BMW, Mercedes, Fiat, Kia, Subaru ");
            Console.WriteLine("Type one of the cars above.");
            string carType = Console.ReadLine();
            foreach (string car in cars)

            {
                if (car == carType)
                {
                    Console.WriteLine("I have Found: " + car);
                    break;
                }

                else
                {
                    Console.WriteLine(carType + " I'm sorry that car is not on the list!");
                }
            }
            Console.ReadLine();


            //Part 5:
            string[] states = { "New Jersey", "New York", "Pennsylvania", "California", "Georgia", "Ohio"};
            Console.WriteLine("Please choose one of the following states: New Jersey, New York, Pennsylvania, California, Georgia, Ohio");
            string stateName = Console.ReadLine();
            for (int k = 0; k < states.Length; k++)

            {
                if (states[k] == stateName)
                {
                    Console.WriteLine("We have found " + states[k] + " in our records!");
                    break;
                }
                else
                {
                    Console.WriteLine("\"" + stateName + "\"" + "does not have a match in our records!");
                }

            }
            Console.ReadLine();



            //Part 6:
            List<string> dogs = new List<string>() { "Labrador", "Rottweiler", "Pitbull", "Chihuahua", "Rottweiler", "Golden Doodle", "Dalmation"};
            foreach (string dog in dogs)
            {
                Console.WriteLine("List of Dogs: " + dog);
            }


            IEnumerable<string> duplicates = dogs.GroupBy(x => x)
                                            .Where(g => g.Count() > 1)
                                            .Select(x => x.Key);
            foreach (string duplicate in duplicates)
            {
                Console.WriteLine("These items are already in the list: " + String.Join(",", duplicates) + "\n-----END-----");


            }
            Console.ReadLine();




        }
    }
}
