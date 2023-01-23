using Ali442115450products.Models;
using Microsoft.AspNetCore.Mvc;


namespace Ali442115450products.Controllers
{
    public class ProductsController : Controller
    {

        private List<Product> Products()
        {

            List<Product> products = new List<Product>();


            Product product_1 = new Product()
            {
                Id = 1,
                Name = "ماوس ديث ادر إسينشال أسود",
                Price = 89.11,
            };
            Product product_2 = new Product()
            {
                Id = 2,
                Name = "ماوس موديل او من ",
                Price = 260,
            };
            Product product_3 = new Product()
            {
                Id = 3,
                Name = "ماوس باد ريزر",
                Price = 15,
            };
            Product product_4 = new Product()
            {
                Id = 4,
                Name = "ماوس باد ASA",
                Price = 15,
            };
            Product product_5 = new Product()
            {
                Id = 5,
                Name = "سماعة ريزر كراكين للألعاب",
                Price = 319,
            };
            Product product_6 = new Product()
            {
                Id = 6,
                Name = "ماوس الالعاب لايت سبيد اللاسلكي",
                Price = 393.50,
            };
            Product product_7 = new Product()
            {
                Id = 7,
                Name = "ماوس مارفو سكوربيون G985",
                Price = 79,
            };
            Product product_8 = new Product()
            {
                Id = 8,
                Name = "ماوس لاسلكي بلوتوث ماي ون",
                Price = 59,
            };
            Product product_9 = new Product()
            {
                Id = 9,
                Name = "ستيل سيريس اوركس 3 لاسلكي",
                Price = 499,
            };
            // Here i can re-sort the items :)
            products.Add(product_5);
            products.Add(product_3);
            products.Add(product_4);
            products.Add(product_1);
            products.Add(product_2);
            products.Add(product_6);
            products.Add(product_7);
            products.Add(product_8);
            products.Add(product_9);
            return products;
        }
        
        public IActionResult Index()
        {
             
            return View(Products());
        }

        public IActionResult Details(int id)
        {
            foreach (var item in Products())
            {
                if (item.Id != id)
                {
                    continue;
                } else
                {
                    Product product = new Product()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Price = item.Price
                };
                        return View(product);
                }
            }
            return View();
        }
    }

   
}
