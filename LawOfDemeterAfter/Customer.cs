namespace LawOfDemeterAfter
{
    public class Customer
    {
        public Wallet Wallet { get; } = new Wallet();

        public decimal MakePayment(decimal amount)
        {
            if (Wallet.Money >= amount)
            {
                Wallet.Money -= amount;
                return amount;
            }

            return 0m;
        }
    }
}