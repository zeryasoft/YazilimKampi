using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 25;
            product1.UnitsInStock = 5;

            Product product2 = new Product {Id=2,CategoryId = 5,ProductName = "Kalem",UnitPrice = 2,UnitsInStock = 50};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);

            //int, double, bool,... değer tip
            //diziler, class, abstract class, interface, ... referans tip
        }
    }
}
