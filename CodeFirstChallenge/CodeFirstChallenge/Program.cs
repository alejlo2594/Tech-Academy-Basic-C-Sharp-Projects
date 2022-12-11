using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new School())
            {
                var stud = new Student() { StudentName = "Santiago" };
                ctx.Students.Add(stud);
                ctx.SaveChanges();
                Console.WriteLine();
            }
        }

    }
}
