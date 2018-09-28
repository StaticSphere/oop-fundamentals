using System;

namespace InterfaceSegregationBefore
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonDbService personDbService = new PersonDbService();
            Console.WriteLine(personDbService.GetPersonById(0));
        }
    }
}
