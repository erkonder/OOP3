using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product { Id = 1 , CategoryId = 2 , ProductName = "Masa" 
                , UnitInStock =5 , UnitPrice =4 };
            Product product2 = new Product { Id = 2,CategoryId = 3 , ProductName = "Sandalye" 
                , UnitInStock = 5 , UnitPrice = 450 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);
            productManager.Update(product1);

            
        }
    }
}
