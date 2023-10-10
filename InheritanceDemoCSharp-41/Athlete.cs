using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemoCSharp_41
{
    public class Athlete : Person
    {
        public string Sport { get; set; }

        public void PlayGame()
        {
            Console.WriteLine($"I play {Sport}!");
        }
    }
}
