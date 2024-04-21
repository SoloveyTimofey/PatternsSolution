using FabricMethod.FabricMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IBurgerFactory burgerFactory = new CreateCheeseBurgerFactory();
            var CheeseBurger = burgerFactory.CreateBurger();

            burgerFactory = new CreateChiefBurgerFactory();
            var ChiefBurger = burgerFactory.CreateBurger();

            Console.WriteLine($"CheeseBurger: {CheeseBurger.GetType()}, ChiefBurger: {ChiefBurger.GetType()}");

            Console.ReadLine();
        }
    }
}
