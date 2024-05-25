using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Заместитель
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StockFacade stockFacade = new StockFacade(new DatabaseProxy(new Database()));

            while (true)
            {
                Console.WriteLine("Products: \n");
                foreach (var product in stockFacade.GetProducts())
                {
                    Console.WriteLine(product);
                }
                Console.ReadLine();
                Console.Clear();
            }
           
        }
    }
}
