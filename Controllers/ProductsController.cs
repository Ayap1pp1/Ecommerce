using Ecommerce.Models;
using Ecommerce.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Controllers
{
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {

            var products = ProductRepository.GetProducts().OrderByDescending(x => x.Popular).ThenBy(y => y.Category);
            var productCategories = new List<string> {"All products" };
            productCategories.AddRange(ProductRepository.GetProductCategories().OrderBy(x => x));

            var productsViewModel = new ProductsViewModel
            {
                Products = products.ToList(),
                ProductCategories = productCategories
            };
            return View(productsViewModel);
        }

        [HttpGet("{id}")]
        public IActionResult Details(string id)
        {
            var product = ProductRepository.GetProductById(int.Parse(id));
            return View("~/Views/Products/Details.cshtml", product);
        }
    }
}
