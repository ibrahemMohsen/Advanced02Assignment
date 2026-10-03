using System.Threading.Channels;

namespace Advanced02Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task01
            List<Product> catalog = new()
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
                new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
                new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 }
            };

            //var electronicProducts = Product.SearchProducts(catalog, p => p.Category == "Electronics");
            //var cheapProducts = Product.SearchProducts(catalog, p => p.Price < 50);
            //var availableProducts = Product.SearchProducts(catalog, p => p.Stock > 0);
            //var cheapClothingProducts = Product.SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);

            //Console.WriteLine("--- Electronics ---");
            //foreach (Product product in electronicProducts)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine();

            //Console.WriteLine("--- Under 50 ---");
            //foreach (Product product in cheapProducts)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine();

            //Console.WriteLine("--- In Stock ---");
            //foreach (Product product in availableProducts)
            //{
            //    Console.WriteLine(product);
            //}
            //Console.WriteLine();

            //Console.WriteLine("--- Clothing under 100 ---");
            //foreach (Product product in cheapClothingProducts)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Task 3.1
            //Console.WriteLine("--- Short Report ---");
            //Product.PrintReport(catalog, p => Console.WriteLine(p.Name + " - $" + p.Price));

            //Console.WriteLine();
            //Console.WriteLine("--- Detailed Report ---");
            //Product.PrintReport(catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));
            #endregion

            #region Task 3.2
            //var summaryList = Product.TransformProducts(catalog, p => $"{p.Name} (${p.Price})");
            //Console.WriteLine("--- Summary List ---");
            //foreach(string productSummary in summaryList)
            //{
            //    Console.WriteLine(productSummary);
            //}

            //var priceLabels = Product.TransformProducts(catalog, p => $"{p.Name}: {(p.Price > 100? "Expensive!": "Affordable")}");
            //Console.WriteLine();
            //Console.WriteLine("--- Price Labels ---");
            //foreach (string productPriceLabels in priceLabels)
            //{
            //    Console.WriteLine(productPriceLabels);
            //}
            #endregion

            #region Task 3.3
            //var lowStockProducts = Product.FilterProducts(catalog, p => p.Stock < 20);
            //Console.WriteLine("--- Low-Stock Alert");
            //foreach(Product product in lowStockProducts)
            //{
            //    Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
            //}
            #endregion
        }
    }
}
