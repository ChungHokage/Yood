using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace X.Application.ViewModel.Category
{
    public class CategoryViewModel
    {
        public Guid Id { get; set; }
        public Guid ParentId { get; set; } = Guid.Empty;
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? SeoAlias { get; set; }
        public string? SeoTitle { get; set; }
        public string? SeoDescription { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}