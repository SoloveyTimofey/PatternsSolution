using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шаблонный_метод
{
    public abstract class BeverageMaker
    {
        public void MakeBeverage()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
            Console.WriteLine("Your beverage is ready!");
        }

        protected abstract void Brew();
        protected abstract void AddCondiments();

        protected void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup...");
        }
    }
}
