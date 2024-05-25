using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фасад
{
    public class Database
    {
        private List<string> Products = new List<string>
        {
            "First Product",
            "Second Product",
            "Third Product",
            "Fourth Product",
            "Fifth Product",
            "Sixth Product"
        };

        public void AddProduct(string product)
        {
            Products.Add(product);
            Console.WriteLine($"You added {product}");
        }

    }
}
