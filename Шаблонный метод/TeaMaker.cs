using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шаблонный_метод
{
    public class TeaMaker : BeverageMaker
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon...");
        }

        protected override void Brew()
        {
            Console.WriteLine("Steeping tea...");
        }
    }
}
