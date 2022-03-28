using System.Collections.Generic;

namespace Ecommerce.Models
{
    public class ProductsViewModel
    {
        public List<Product> Products { get; set; }
        public List<string> ProductCategories { get; set; }
    }
}
