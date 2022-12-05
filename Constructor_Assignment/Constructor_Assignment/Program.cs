using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    public class Program
    {
        public class Events
        {
            public Events(string companyName) : this (companyName, 150) { }

            public Events(string companyName, int minClients)
            {                                                                           
            }

            public string companyName { get; set; }
            public int minClients { get; set; }
        }

        const string welcome = "Welcome to the team ";

        Events companyName = new Events("Tari's Party Planning");

        public static void Main(string[] args)
        {
            var years = "3";
            string member = "Tariana Torres";

            Console.WriteLine("{0} {1}! She has been in business for {2} years", welcome, member, years);
            Console.ReadLine();
        }
    }
}
