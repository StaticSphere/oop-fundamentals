using System;
using System.Collections.Generic;

namespace LawOfDemeterAfter
{
    public class Paperboy
    {
        public List<Customer> Customers { get; set; }
        private decimal fundsCollected;

        public Paperboy()
        {
            Customers = new List<Customer>
            {
                new Customer(),
                new Customer(),
                new Customer(),
            };
        }

        public void CollectPayments()
        {
            // Paper costs $2.00
            decimal charge = 2m;

            // This code fixes the violation of the Law of Demeter in the LawOfDemeterBefore/Paperboy.cs file,
            // in that it makes no assumptions about how a customer pays. The Paperboy is only asking that the
            // customer pays, and takes no part in HOW the customer pays.
            foreach (Customer customer in Customers)
            {
                decimal payment = customer.MakePayment(charge);

                if (payment != 0m)
                    fundsCollected += payment;
            }

            Console.WriteLine($"Collected {fundsCollected:C2} from customers.");
        }
    }
}