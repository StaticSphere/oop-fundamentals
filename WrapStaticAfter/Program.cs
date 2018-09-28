using System;

namespace WrapStaticAfter
{
    class Program
    {
        static void Main(string[] args)
        {
            // In a real application, this would be passed in via
            // dependency injection. Because the Path and Directory
            // static classes used within the LineReader class call
            // to outside resources, they should be wrapped to support
            // unit testing.
            ILineReader reader = new LineReader();
            var lines = reader.ReadLines("Lines.txt");

            // Static classes that ONLY execute local code, and are
            // known NOT to make calls to outside resources, don't
            // need to be wrapped.
            Console.WriteLine(String.Join(Environment.NewLine, lines));
        }
    }
}
