using System;

namespace ConstructorAfter
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.InitializeFromFile();
            Console.WriteLine(person.ToString());
        }
    }
}
