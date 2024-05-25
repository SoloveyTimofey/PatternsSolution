using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Заместитель
{
    public class DatabaseProxy : IDatabase
    {
        private readonly IDatabase database;
        private (DateTime, List<string>) cachedProducts;
        public DatabaseProxy(IDatabase database)
        {
            this.database = database;
        }
        public void AddProduct(string product)
        {
            database.AddProduct(product);
        }

        public List<string> GetProducts()
        {            
            CheckIfProductsActual();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\tYou got products at {DateTime.Now}\n");
            Console.ResetColor();

            return cachedProducts.Item2;
        }

        private void CheckIfProductsActual()
        {
            if (cachedProducts.Item2==null)
            {
                cachedProducts.Item1 = DateTime.Now;
                cachedProducts.Item2 = database.GetProducts();
            }

            if ((DateTime.Now-cachedProducts.Item1).Seconds>10)
            {
                cachedProducts.Item1 = DateTime.Now;
                cachedProducts.Item2 = database.GetProducts();
            }
        }
    }
}
