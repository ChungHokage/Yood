namespace X.Data.Entities
{
    public class OrderDetail
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public int Quanity { get; set; }
    }
}