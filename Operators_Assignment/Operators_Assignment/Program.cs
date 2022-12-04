using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee>();
            Employee Employeeid1 = new Employee();
            Employeeid1.FirstName = "John";
            Employeeid1.LastName = "Doe";
            Employeeid1.id = 1;
            EmployeeList.Add(Employeeid1);

            Employee Employeeid2 = new Employee();
            Employeeid2.FirstName = "Jane";
            Employeeid2.LastName = "Dawson";
            Employeeid2.id = 2;
            EmployeeList.Add(Employeeid2);

            Console.WriteLine(Employeeid1 == Employeeid2);
            Console.WriteLine(Employeeid1 != Employeeid2);

            Console.ReadLine();

          
        }
    }
}
