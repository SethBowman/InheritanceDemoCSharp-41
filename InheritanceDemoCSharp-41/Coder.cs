using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemoCSharp_41
{
    public class Coder : Person
    {

        public string ProgrammingLang { get; set; }

        public void Code()
        {
            Console.WriteLine($"I can code in {ProgrammingLang}!");
        }
    }
}
