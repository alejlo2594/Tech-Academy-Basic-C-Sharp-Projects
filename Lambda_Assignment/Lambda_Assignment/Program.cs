using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> theOffice = new List<Employee>();

            List<Employee> Employees = new List<Employee>
            {
                new Employee { FirstName = "Michael", LastName = "Scott", ID = 1 },
                new Employee { FirstName = "Jim", LastName = "Halpert", ID = 2 },
                new Employee { FirstName = "Joe", LastName = "Schrute", ID = 3 },
                new Employee { FirstName = "Pamela", LastName = "Beesly", ID = 4 },
                new Employee { FirstName = "Stanley", LastName = "Hudson", ID = 5 },
                new Employee { FirstName = "Kevin", LastName = "Malone", ID = 6 },
                new Employee { FirstName = "Joe", LastName = "Martin", ID = 7 },
                new Employee { FirstName = "Oscar", LastName = "Martinez", ID = 8 },
                new Employee { FirstName = "Meredith", LastName = "Palmer", ID = 9 },
                new Employee { FirstName = "Kelly", LastName = "Kapoor", ID = 10 },
            };


            foreach (Employee employee in Employees)
            {
                if (employee.FirstName.Equals("Joe"))
                {
                    theOffice.Add(employee);
                }
            }
            foreach (Employee employees in theOffice)
            {
                Console.WriteLine(employees.FirstName + " " + employees.LastName);
            }
            Console.ReadLine();


            List<Employee> joeList = Employees.Where(x => x.FirstName == ("Joe")).ToList();

            foreach (Employee x in joeList)
            {
                Console.WriteLine(x.FirstName + x.LastName);
            }

            List<Employee> otherList = Employees.Where(x => x.ID > 5).ToList();

            foreach (Employee y in otherList)
            {
                Console.WriteLine(y.ID + y.FirstName + " " + y.LastName);
            }
            Console.ReadLine();
        }
    }
}
