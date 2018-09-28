namespace SingleResponsibilityAfter.DataModels
{
    public class Order
    {
        public string ItemId { get; set; }
        public int Quantity { get; set; }
        public bool Expedite { get; set; }
    }
}