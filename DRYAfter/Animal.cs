namespace DRYAfter
{
    public abstract class Animal
    {
        protected int ThreadId { get; set; }

        public Animal(int threadId)
        {
            ThreadId = threadId;
        }

        public abstract string Verbalize();
    }
}