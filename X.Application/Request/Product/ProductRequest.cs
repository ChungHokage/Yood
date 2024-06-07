namespace X.Application.Request.Product
{
    public class ProductRequest
    {
        public string? ProductCode { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Material { get; set; }
        public string? Usage { get; set; }
    }
}