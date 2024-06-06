﻿namespace X.Data.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? ProductCode { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Material { get; set; }
        public string? Usage { get; set; }
        public List<ProductDetail> ProductDetails { get; set; }
        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<CartDetail> CartDetails { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}