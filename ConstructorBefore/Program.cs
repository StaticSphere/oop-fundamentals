using System;

namespace ConstructorBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            Console.WriteLine(person.ToString());
        }
    }
}
