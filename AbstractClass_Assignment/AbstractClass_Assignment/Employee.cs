﻿using System;
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
            base.SayName();
        }

        public void Quit(Person FirstName, Person LastName)
        {
            throw new NotImplementedException();
        }
    }
}
