using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фасад
{
    public class Program
    {
        static void Main(string[] args)
        {
            StockFacade stockFacade = new StockFacade();

            stockFacade.NewProductArrived("Vape");

            Console.WriteLine("\n\t************************\n");

            stockFacade.NewProductArrived("Water");

            Console.ReadLine();
        }
    }
}
