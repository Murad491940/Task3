﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
     class Student : Person
    {
        public Student(string name, string surname, int age) : base(name, surname, age)
        {

        }
        public void Learn()
        {
            Console.WriteLine("Learning");
        }
    }
}
