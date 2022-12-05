using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int id { get; set; }
        public Employee()
        {
            id = 0;
        }

        public Employee(int Employeeid1)
        {
            id = Employeeid1;
        }

        public static bool operator == (Employee Employeeid1, Employee Employeeid2)
        {
            return Employeeid1.id == Employeeid2.id;
        }

        public static bool operator !=(Employee Employeeid1, Employee Employeeid2)
        {
            return Employeeid1.id != Employeeid2.id;
        }

       

    }
}
