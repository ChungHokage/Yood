using X.Data.Enum;

namespace X.Application.Request.Product
{
    public class ProductDetailRequest
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Size Size { get; set; }
        public string ColorId { get; set; }
        public int QuanityRemaining { get; set; }
        public int QuanitySold { get; set; }
    }
}