using System;
using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrice(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach(Product prod in products)
            {
                total += prod?.Price ?? 0M;
            }

            return total;
        }

        //public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> productEnum, decimal minimumPrice)
        //{
        //    foreach(Product prod in productEnum)
        //    {
        //        if ((prod?.Price ?? 0) >= minimumPrice)
        //        {
        //            yield return prod;
        //        }
        //    }
        //}

        //public static IEnumerable<Product> FilterByName(this IEnumerable<Product> productEnum, char firstLetter)
        //{
        //    foreach (var prod in productEnum)
        //    {
        //        if(prod?.Name?[0] == firstLetter)
        //        {
        //            yield return prod;
        //        }
        //    }
        //}

        public static IEnumerable<Product> Filter(this IEnumerable<Product> productEnum, Func<Product, bool> seletor)
        {
            foreach (var prod in productEnum)
            {
                if (seletor(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}
