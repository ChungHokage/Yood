using X.Data.Enum;

namespace X.Application.ViewModel.Product
{
    public class ProductDetailViewModel
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Size Size { get; set; }
        public string ColorId { get; set; }
        public int QuanityRemaining { get; set; }
        public int QuanitySold { get; set; }
    }
}