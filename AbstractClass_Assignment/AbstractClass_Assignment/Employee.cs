using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Assignment
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Full Name: " + FirstName + " "+ LastName);
        }

        public void Quit(string quit)
        {
            Console.WriteLine("Following employee has quit: " + FirstName + LastName);
        }

    }
}
