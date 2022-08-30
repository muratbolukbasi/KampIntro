using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
            new Category{CategoryId=1 , CategoryName ="Bilgisayar"},
            new Category { CategoryId = 2, CategoryName = "Telefon" },
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuatityPerUnit="32 GB RAM",UnitPrice=10000,UnitsInStock=5},
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuatityPerUnit="16 GB RAM",UnitPrice=8000,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuatityPerUnit="8 GB RAM",UnitPrice=6000,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung Telefon",QuatityPerUnit="4 GB RAM",UnitPrice=5000,UnitsInStock=15},
                new Product{ProductId=5,CategoryId=2,ProductName="Apple Telefon",QuatityPerUnit="4 GB RAM",UnitPrice=8000,UnitsInStock=0},
            };

            Console.WriteLine("ALGORİTMİK");

            foreach (var product in products)
            {
                if (product.UnitPrice>5000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
                
            }

            Console.WriteLine("Linq ile yapılmış kod----------");

            var result = products.Where( product=>product.UnitPrice>5000 && product.UnitsInStock>3 );

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            GetProducts(products);
        }

        

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProduct = new List<Product>();
            foreach (var product in products)
            {
                if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
                {
                    filteredProduct.Add(product);
                }

            }
            return filteredProduct;
        }

        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 5000 && product.UnitsInStock > 3).ToList();
        }

    }
}

class Product
{
    public int ProductId { get; set; }
    public int CategoryId { get; set; }
    public string ProductName { get; set; }
    public string QuatityPerUnit { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
}

class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
