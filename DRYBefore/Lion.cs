namespace DRYBefore
{
    public class Lion : Animal
    {
        public Lion(int threadId)
            : base(threadId)
        {
        }

        public override string Verbalize()
        {
            return $"Roar from thread ID = {ThreadId}";
        }
    }
}