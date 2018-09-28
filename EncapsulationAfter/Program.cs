using System;

namespace EncapsulationAfter
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new MyStack<int>();

            for (var i = 0; i < 10; i++)
                stack.Push(i);

            while (stack.HasMoreItems)
                Console.WriteLine(stack.Pop());
        }
    }
}
