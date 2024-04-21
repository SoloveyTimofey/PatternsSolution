using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBurgerBuilder burgerBuilder = new BurgerBuilder(new Burger());

            BurgerChiefDirector director = new BurgerChiefDirector(burgerBuilder);

            Console.WriteLine(director.MakeChiefBurger());
            Console.WriteLine(director.MakeCheeseburger());
            Console.WriteLine(director.MakeHomeBurger());

            Console.ReadLine();
        }
    }
}
