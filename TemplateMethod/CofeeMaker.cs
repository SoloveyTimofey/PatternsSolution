using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шаблонный_метод
{
    public class CofeeMaker : BeverageMaker
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk...");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brewing cofee...");
        }
    }
}
