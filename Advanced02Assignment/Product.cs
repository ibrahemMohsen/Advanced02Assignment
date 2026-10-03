using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced02Assignment
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; } // "Electronics", "Clothing", "Food", "Books" 
        public double Price { get; set; }
        public int Stock { get; set; }
        public static List<Product> SearchProducts(List<Product> Products, Func<Product, bool> Filter)
        {
            List<Product> matchingProducts = new List<Product>();
            foreach (Product product in Products)
            {
                if (Filter(product))
                {
                    matchingProducts.Add(product);
                }
            }
            return matchingProducts;
        }
        public static void PrintReport(List<Product> Products, Action<Product> Action)
        {
            foreach(Product product in Products)
            {
                Action(product);
            }
        }
    }

}
