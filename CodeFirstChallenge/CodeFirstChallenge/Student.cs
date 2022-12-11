using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirstChallenge
{
    public class Student : DbContext
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateofBirth { get; set; }
        public int Grade { get; set; }
    }
}
