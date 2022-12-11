using System;
using System.Data.Entity;
using System.Linq;


namespace CodeFirstChallenge
{
    public class School : DbContext
    {

        public School() : base()
        {

        }

        public DbSet<Student> Students { get; set; }

    }    

 }