namespace DRYBefore
{
    public class Dog : Animal
    {
        public Dog(int threadId)
            : base(threadId)
        {
        }

        public override string Verbalize()
        {
            return $"Bark from thread ID = {ThreadId}";
        }
    }
}