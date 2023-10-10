
using InheritanceDemoCSharp_41;

var seth = new Person();

seth.Name = "Seth";
seth.Age = 29;

seth.Greet();

var bob = new Coder();

bob.Name = "Bob";

bob.Greet();

bob.ProgrammingLang = "C#";

bob.Code();

var bill = new Athlete();

bill.Name = "Bill";
bill.Age = 29;
bill.Greet();

bill.Sport = "Football";

bill.PlayGame();

var crowd = new List<Person>() { seth, bob, bill };

foreach(var person in crowd)
{
    if(person is Coder)
    {
        Console.WriteLine($"My name is {person.Name} and I am a coder!");
    }
    else if(person is Athlete)
    {
        Console.WriteLine($"My name is {person.Name} and I am an athlete!");
    }
    else
    {
        Console.WriteLine($"My name is {person.Name} and I'm just a regular ole guy!");
    }
}