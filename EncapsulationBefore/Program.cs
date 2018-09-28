using System;

namespace EncapsulationBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack<int>();

            for (var i = 0; i < 10; i++)
                stack.Push(i);

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
        }
    }
}
