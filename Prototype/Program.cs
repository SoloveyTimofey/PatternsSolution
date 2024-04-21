using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricMethod.Classes;

namespace Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ChiefBurgerPrototype firstChiefBurger = new ChiefBurgerPrototype();
            
            ChiefBurgerPrototype secondChiefBurger = firstChiefBurger.Clone() as ChiefBurgerPrototype;

            Console.WriteLine($"Is referances queals {ReferenceEquals(firstChiefBurger, secondChiefBurger)}");

            Console.WriteLine($"First burger components: " +
                $"\n\t{firstChiefBurger.Bun.Type}"+
                $"\n\t{firstChiefBurger.Cutlets.First().Type}");

            Console.WriteLine($"Second burger components: " +
                $"\n\t{secondChiefBurger.Bun.Type}"+
            $"\n\t{secondChiefBurger.Cutlets.First().Type}");

            Console.ReadLine();
        }
    }
}
