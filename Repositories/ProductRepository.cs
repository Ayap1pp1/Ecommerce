using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;

namespace Ecommerce.Repositories
{
    public static class ProductRepository
    {
        private static IEnumerable<Product> _products = new List<Product>();

        public static IEnumerable<Product> GetProducts()
        {

            if (!_products.Any())
            {
                LoadProducts();
            }

            return _products;
        }
                
        public static Product GetProductById(int id)
        { 
            return _products.FirstOrDefault(z => z.Id == id);
        }

        public static List<string> GetProductCategories()
        {
            return _products.Select(x => x.Category).Distinct().ToList();
        }

        private static void LoadProducts()
        {
            string fileName = "Data\\products.json";
            string jsonString = File.ReadAllText(fileName);
            _products = JsonSerializer.Deserialize<IEnumerable<Product>>(jsonString);
        }
    }
}
