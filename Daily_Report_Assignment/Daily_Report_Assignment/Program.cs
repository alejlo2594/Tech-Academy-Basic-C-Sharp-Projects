using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opening sentence
            Console.WriteLine("The Tech Academy");
            Console.ReadLine();

            //Student Daily Report
            Console.WriteLine("Student Daily Report");
            Console.ReadLine();

            //Question A 
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            //Question B
            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("You are currently on the " + yourCourse + " course!");
            Console.ReadLine();

            //Question C 
            Console.WriteLine("What page number?");
            Console.ReadLine();
            int currentPage = 180;
            string pageNumber = currentPage.ToString();
            Console.WriteLine(pageNumber);
            Console.ReadLine();
            

            //Question D
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            Console.ReadLine();
            bool needHelp = true;
            string helpStatus = Convert.ToString(needHelp);
            Console.WriteLine(helpStatus);
            Console.ReadLine();

            //Question E
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            Console.ReadLine();
            Console.WriteLine("Thank you for your response");
            Console.ReadLine();

            //Question F
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            Console.ReadLine();
            Console.WriteLine("Thank you for your feedback");
            Console.ReadLine();

            //Question G
            Console.WriteLine("How many hours did you study today?");
            int studyToday = 8;
            string hoursStudied = studyToday.ToString();
            Console.WriteLine(hoursStudied);
            Console.ReadLine();

            //Last response
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
