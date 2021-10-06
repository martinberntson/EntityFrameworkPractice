using EntityFrameworkPractice.Data;
using EntityFrameworkPractice.Models;
using System;
using System.Linq;

namespace EntityFrameworkPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            using EFPracticeContext context = new EFPracticeContext();

            var squeakyBone = context.Products
                                .Where(p => p.Name == "Squeaky Dog Bone")
                                .FirstOrDefault();
            if(squeakyBone is Product)
            {
                squeakyBone.Price = 7.99m;
                // context.Remove(squeakyBone);
            }
            context.SaveChanges();

            var products = context.Products
                .Where(products => products.Price >= 5.00m)
                .OrderBy(p => p.Name);
            /*
             * var products =   from product in context.Products
             *                  where product.Price > 5.00m
             *                  orderby product.Name
             *                  select product;
             *                                                  Gives the same result.
             */

            foreach (Product p in products)
            {
                Console.WriteLine($"Id:    {p.ValueThatIsUniqueForThisItem}\n" +
                                  $"Name:  {p.Name}\n" +
                                  $"Price: {p.Price}\n");
                Console.WriteLine(new string('-', 20));
            }
        }
    }
}
