using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шаблонный_метод
{
    public class Program
    {
        static void Main(string[] args)
        {
            BeverageMaker cofeeMaker = new CofeeMaker();
            BeverageMaker teaMaker = new TeaMaker();

            Console.WriteLine("Making cofee:");
            cofeeMaker.MakeBeverage();

            Console.WriteLine("\nMaking tea:");
            teaMaker.MakeBeverage();

            Console.ReadLine();
        }
    }
}
