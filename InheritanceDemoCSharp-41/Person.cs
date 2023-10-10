using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemoCSharp_41
{
    public class Person
    {
        //properties
        public string Name { get; set; }
        public int Age { get; set; }

        //methods
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name}!");
        }
    }
}
