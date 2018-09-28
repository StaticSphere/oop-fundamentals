using System;
using System.IO;

namespace WrapStaticBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static classes that reach out to external resources (in
            // this case, the file system) are bad, because they can't
            // be mocked when writing unit tests against our code.
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Lines.txt");
            var lines = File.ReadAllLines(filePath);

            Console.WriteLine(String.Join(Environment.NewLine, lines));
        }
    }
}
