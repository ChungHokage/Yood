using System.Drawing;

namespace X.Data.Entities
{
    public class ProductDetail
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Size Size { get; set; }
        public Color ColorId { get; set; }
        public int QuanityRemaining { get; set; }
        public int QuanitySold { get; set; }
    }
}