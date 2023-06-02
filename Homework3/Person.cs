using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
        public Person(string name,string surname,int age) 
        { 
         Name = name;
         SurName = surname;
         Age = age;

        }

    }
}
