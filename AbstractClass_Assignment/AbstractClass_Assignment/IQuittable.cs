using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Assignment
{
    interface IQuittable
    {
        void Quit()
        {
            Console.WriteLine("The following Employee has resigned: ");
        }
    }
}
