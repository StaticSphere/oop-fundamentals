using System;

namespace LawOfDemeterBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            var paperboy = new Paperboy();
            paperboy.CollectPayments();
        }
    }
}
