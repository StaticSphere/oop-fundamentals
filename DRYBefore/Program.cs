using System;
using System.Threading;

namespace DRYBefore
{
    class Program
    {
        // Even though these methods aren't exact clones of each other,
        // they're doing effectively the same thing; creating an animal.
        // This can be cleaned up.
        public static Dog GetDog()
        {
            return new Dog(Thread.CurrentThread.ManagedThreadId);
        }

        public static Cat GetCat()
        {
            return new Cat(Thread.CurrentThread.ManagedThreadId);
        }

        public static Bird GetBird()
        {
            return new Bird(Thread.CurrentThread.ManagedThreadId);
        }

        public static Lion GetLion()
        {
            return new Lion(Thread.CurrentThread.ManagedThreadId);
        }

        static void Main(string[] args)
        {
            var dog = GetDog();
            var cat = GetCat();
            var bird = GetBird();
            var lion = GetLion();

            // This code is alos repetative, and can be cleaned up.
            Console.WriteLine(dog.Verbalize());
            Console.WriteLine(cat.Verbalize());
            Console.WriteLine(bird.Verbalize());
            Console.WriteLine(lion.Verbalize());
        }
    }
}
