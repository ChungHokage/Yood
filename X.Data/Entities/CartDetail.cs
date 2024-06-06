using X.Data.Enum;

namespace X.Data.Entities
{
    public class CartDetail
    {
        public Guid Id { get; set; }
        public Guid CartId { get; set; }
        public Guid ProductId { get; set; }
        public int Quanity { get; set; }
        public decimal Price { get; set; }
        public string ColorId { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public Product Product { get; set; }
        public Cart Cart { get; set; }
    }
}