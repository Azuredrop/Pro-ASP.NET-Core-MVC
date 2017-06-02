using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using LanguageFeatures.Models;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //bool FilterByPrice(Product p)
        //{
        //    return (p?.Price ?? 0) >= 20;
        //}

        public ViewResult Index()
        {
            //List<string> results = new List<string>();

            //foreach(Product p in Product.GetProducts())
            //{
            //    string name = p?.Name ?? "<No Name>";
            //    decimal? price = p?.Price ?? 0M;
            //    string relatedName = p?.Related?.Name ?? "<None>";
            //    results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            //}

            //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };

            //Product[] productArray =
            //{
            //    new Product {Name="Kayak",Price=275M },
            //    new Product {Name="Lifejacket",Price=48.95M },
            //    new Product {Name="Soccer ball",Price=19.50M },
            //    new Product {Name="Corner flag",Price=34.95M }
            //};

            //decimal cartTotal = cart.TotalPrice();
            //decimal arrayTotal = productArray.TotalPrice();
            //decimal priceFilterTotal = productArray.FilterByPrice(20).TotalPrice();
            //decimal nameFilterTotal = productArray.FilterByName('S').TotalPrice();

            //Func<Product, bool> nameFilter = delegate (Product prod)
            //{
            //    return prod?.Name?[0] == 'S';
            //};
            //decimal priceFilterTotal = productArray.Filter(FilterByPrice).TotalPrice();
            //decimal nameFilterTotal = productArray.Filter(nameFilter).TotalPrice();

            //decimal priceFilterTotal = productArray.Filter(p => (p?.Price ?? 0) >= 20).TotalPrice();
            //decimal nameFilterTotal = productArray.Filter(p => p?.Name?[0] == 'S').TotalPrice();

            //return View("Index", new string[] {
            //    $"Price Filter Total: {priceFilterTotal:C2}" ,
            //    $"Name Filter Total: {nameFilterTotal:C2}" });

            //return View(Product.GetProducts().Select(p => p?.Name));

            //var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };

            //return View(names);

            var products = new[]
            {
                new {Name = "Kayak", Price = 275M},
                new {Name = "Lifejacket", Price = 48.95M},
                new {Name = "Soccer ball", Price = 19.50M},
                new {Name = "Corner flag", Price = 34.95M}
            };

            //return View(products.Select(p => $"Name: {p.Name}, Price: {p.Price}"));
            return View(products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}"));
        }

        //public async Task<ViewResult> Index()
        //{
        //    long? length = await MyAsyncMethods.GetPageLength();
        //    return View(new string[] { $"Length: {length}" });
        //}
    }
}
