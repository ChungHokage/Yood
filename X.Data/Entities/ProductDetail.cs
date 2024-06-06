using Microsoft.Identity.Client;
using X.Data.Enum;

namespace X.Data.Entities
{
    public class ProductDetail
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Size Size { get; set; }
        public string ColorId { get; set; }
        public int QuanityRemaining { get; set; }
        public int QuanitySold { get; set; }
        public Product Product { get; set; }
        public Color Color { get; set; }
    }
}