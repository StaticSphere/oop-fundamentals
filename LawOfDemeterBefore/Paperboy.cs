using System;
using System.Collections.Generic;

namespace LawOfDemeterBefore
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

            // This code violates the Law of Demeter due to the fact that it's calling in to the Wallet
            // property, and accessing its Money value.  The Paperboy type "knows" too much about how
            // a customer pays. Should the paperboy care whether the payment came from a wallet, or a bag,
            // or a cookie jar, as long as they get paid?
            foreach (Customer customer in Customers)
            {
                if (customer.Wallet.Money >= charge)
                {
                    customer.Wallet.Money -= charge;
                    fundsCollected += charge;
                }
            }

            Console.WriteLine($"Collected {fundsCollected:C2} from customers.");
        }
    }
}