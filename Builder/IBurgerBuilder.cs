using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBurgerBuilder
    {
        IBurgerBuilder AddCheese(Cheese cheese);
        IBurgerBuilder AddBun(Bun bun);
        IBurgerBuilder AddCutlet(Cutlet cutlet);
        IBurgerBuilder AddSouce(Souce souce);
        IBurgerBuilder AddVegetable(Vegetable vegetable);
        IBurgerBuilder SetName(string name);
        Burger GetBurger();
    }
}
