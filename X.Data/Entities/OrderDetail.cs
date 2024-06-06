namespace X.Data.Entities
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
        public int Quanity { get; set; }
        public Order? Order { get; set; }
        public Product Product { get; set; }
    }
}