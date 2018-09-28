namespace DRYAfter
{
    public class Cat : Animal
    {
        public Cat(int threadId)
            : base(threadId)
        {
        }

        public override string Verbalize()
        {
            return $"Meow from thread ID = {ThreadId}";
        }
    }
}