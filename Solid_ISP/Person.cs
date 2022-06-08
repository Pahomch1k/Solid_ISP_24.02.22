using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_ISP
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person() : this("Oleg", 0) { }

        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }

        public override string ToString()
        {
            return $"{Name}, {Age}";
        }
    }
}
