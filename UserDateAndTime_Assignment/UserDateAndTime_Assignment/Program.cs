using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UserDateAndTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);

            Console.WriteLine("Please type a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            DateTime addTime = currentTime.AddHours(userNum);

            Console.WriteLine(addTime);
            Console.ReadLine();
        }
    }
}
