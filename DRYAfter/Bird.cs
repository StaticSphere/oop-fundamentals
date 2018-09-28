namespace DRYAfter
{
    public class Bird : Animal
    {
        public Bird(int threadId)
            : base(threadId)
        {
        }

        public override string Verbalize()
        {
            return $"Chirp from thread ID = {ThreadId}";
        }
    }
}