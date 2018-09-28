using System;
using System.Threading;

namespace DRYAfter
{
    class Program
    {
        // Rather than haing a method for each of our animals, we have a SINGLE
        // method that can create ANY animal.
        public static TAnimal GetAnimal<TAnimal>()
            where TAnimal: Animal
        {
            var threadId = Thread.CurrentThread.ManagedThreadId;
            return (TAnimal)Activator.CreateInstance(typeof(TAnimal), threadId);
        }

        static void Main(string[] args)
        {
            // This could technically be cleaned up further using .NET's Reflection
            // API, but you would likely lose control of ordering if that was important.
            // While we should strive for DRY, you can take it too far as well.
            var animals = new Animal[] {
                GetAnimal<Dog>(),
                GetAnimal<Cat>(),
                GetAnimal<Bird>(),
                GetAnimal<Lion>()
            };

            // Before, we were manually calling Console.WriteLine for each animal.
            // Now, we're treating them as a collection, and enumerating them, calling
            // Verbalize on each.
            foreach(var animal in animals)
                Console.WriteLine(animal.Verbalize());
        }
    }
}
