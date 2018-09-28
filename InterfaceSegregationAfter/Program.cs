using System;

namespace InterfaceSegregationAfter
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonDbQueryService personDbService = new PersonDbService();
            Console.WriteLine(personDbService.GetPersonById(0));
        }
    }
}
