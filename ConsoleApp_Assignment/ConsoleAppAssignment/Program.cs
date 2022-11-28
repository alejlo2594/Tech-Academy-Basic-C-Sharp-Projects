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
            string[] names = { "James", "Ella", "Chris", "Aly" };
            Console.WriteLine("Please type a word:");
            string word1 = Console.ReadLine();
            for (int j = 0; j < names.Length; j++)
            {
                names[j] = names[j] + word1;
            }
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine(names[j]);
            }
            Console.ReadLine();




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
            Console.ReadLine();

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
            List<string> cars = new List<string> { "Honda", "Toyota", "BMW", "Mercedes", "Fiat", "Kia", "Subaru" };
            Console.WriteLine("Select one of the following:  Honda, Toyota, BMW, Mercedes, Fiat, Kia, Subaru ");
            string carType = Console.ReadLine();
            bool found = false;
            for (int a = 0; a < cars.Count; a++)

            {
                if (cars[a] == carType)
                {
                    Console.WriteLine(a);
                    found = true;
                    break;
                }
            }
                if (!found)
                {
                    Console.WriteLine(" I'm sorry that car is not on the list!");
                }
            
             Console.ReadLine();


            //Part 5:
            List<string> states = new List<string> { "New Jersey", "New York", "Pennsylvania", "California", "Georgia", "Ohio", "New York" };
            Console.WriteLine("Please choose one of the following states: New Jersey, New York, Pennsylvania, California, Georgia, Ohio");
            string stateName = Console.ReadLine();
            bool seen = false;
            for (int k = 0; k < states.Count; k++)

            {
                if (states[k] == stateName)
                {
                    Console.WriteLine(k);
                    seen = true;
                }
            }
                if (!seen) 
                {
                    Console.WriteLine("Does not have a match in our records!");
                }
            
            Console.ReadLine();



            //Part 6:
            List<string> dogs = new List<string>() { "Labrador", "Rottweiler", "Pitbull", "Chihuahua", "Rottweiler", "Golden Doodle", "Dalmation" };
            List<string> dogs1 = new List<string>() { };
            foreach (string dog in dogs)
            {
                if (dogs1.Contains(dog))
                {
                    Console.WriteLine("This item is already in the list: " + dog);
                }
                else
                {
                    Console.WriteLine("This item is unique " + dog);
                    dogs1.Add(dog);
                }

            }
            Console.ReadLine();

        }
    }
}
