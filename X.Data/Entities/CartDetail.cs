using X.Data.Enum;

namespace X.Data.Entities
{
    public class CartDetail
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public int Quanity { get; set; }
        public decimal Price { get; set; }
        public string ColorId { get; set; }
        public Size Size { get; set; }
    }
}