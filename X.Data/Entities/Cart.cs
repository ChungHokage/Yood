namespace X.Data.Entities
{
    public class Cart
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
        public decimal OrderValue { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalValue { get; set; }
        public AppUser User { get; set; }
        public List<CartDetail> CartDetails { get; set; }
    }
}