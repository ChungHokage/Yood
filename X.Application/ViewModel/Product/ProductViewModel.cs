﻿namespace X.Application.ViewModel.Product
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string? ProductCode { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? Material { get; set; }
        public string? Usage { get; set; }
    }
}