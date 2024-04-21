using FabricMethod.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.FabricMethods
{
    public class CreateCheeseBurgerFactory : IBurgerFactory
    {
        public Burger CreateBurger() => new CheeseBurger()
        {
            BunType = new Bun(BunType.Wheat),
            Cutlet = new Cutlet(CutletType.Chiken),
            Cheeses = new List<Cheese> { new Cheese(CheeseType.Cheddar), new Cheese(CheeseType.Cheddar)}
        };
    }
}
