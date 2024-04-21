using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BurgerChiefDirector
    {
        IBurgerBuilder burgerBuilder;
        public BurgerChiefDirector(IBurgerBuilder burgerBuilder)
        {
            this.burgerBuilder = burgerBuilder;
        }

        public Burger MakeCheeseburger()
        {
            return burgerBuilder
                .SetName("Cheeseburger")
                .AddCheese(new Cheese(CheeseType.Cheddar))
                .AddCutlet(new Cutlet(CutletType.Chiken))
                .AddSouce(new Souce(SouceType.Ketchup))
                .AddBun(new Bun(BunType.Wheat))
                .GetBurger();
        }

        public Burger MakeChiefBurger()
        {
            return burgerBuilder
                .SetName("Chief Burger")
                .AddCheese(new Cheese(CheeseType.Cheddar))
                .AddCheese(new Cheese(CheeseType.Cheddar))
                .AddSouce(new Souce(SouceType.ChefSpecial))
                .AddCutlet(new Cutlet(CutletType.Beef))
                .AddCutlet(new Cutlet(CutletType.Beef))
                .AddVegetable(new Vegetable(VegetableType.Lettuce))
                .AddVegetable(new Vegetable(VegetableType.Pickle))
                .AddVegetable(new Vegetable(VegetableType.Tomato))
                .AddBun(new Bun(BunType.Black))
                .GetBurger();
        }

        public Burger MakeHomeBurger()
        {
            return burgerBuilder
                .SetName("Home Burger")
                .AddCheese(new Cheese(CheeseType.Goat))
                .AddCutlet(new Cutlet(CutletType.Turkey))
                .AddVegetable(new Vegetable(VegetableType.Tomato))
                .AddVegetable(new Vegetable(VegetableType.Pickle))
                .AddSouce(new Souce(SouceType.Ketchup))
                .AddBun(new Bun(BunType.Rye))
                .GetBurger();
        }

    }
}
