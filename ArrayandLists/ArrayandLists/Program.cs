using System;
using System.Collections.Generic;

namespace ArrayandLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //String Array
            string[] Names = { "Jen", "Ella", "Tiorys", "Sarah", "Lorena" };
            Console.WriteLine("Select a number between 0 - 4 to display an index of the array");
            int namesArray = Convert.ToInt32(Console.ReadLine());

            if (namesArray > 4)
            {
                Console.WriteLine("Index does not exist.");
            }
            else
            {
                Console.WriteLine(Names[namesArray]);
            }


            //Integer Array 
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 10;
            numArray[2] = 15;
            numArray[3] = 20;
            numArray[4] = 25;
            Console.WriteLine("Select a number between 0 - 4 to display an index of the array" );
            int newArray = Convert.ToInt32(Console.ReadLine());

            if (newArray > 4)
            {
                Console.WriteLine("Index does not exist.");
            }
            else
            {
                Console.WriteLine(numArray[newArray]);
            }

            //List of Strings 
            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Hola!");
            intList.Add("Bonjour");
            intList.Add("Ciao");
            intList.Add("Zdravo");
            Console.WriteLine("Select a number between 0 - 4 to display an index of the array");
            int newList = Convert.ToInt32(Console.ReadLine());

            if (newList > 4)
            {
                Console.WriteLine("Index does not exist.");
            }
            else
            {
                Console.WriteLine(intList[newList]);
            }

            Console.ReadLine();


        }
    }
}
