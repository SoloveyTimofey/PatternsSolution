using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class BurgerBuilder : IBurgerBuilder
    {
        private Burger _burger;
        public BurgerBuilder(Burger burger)
        {
            _burger = burger;
        }
        public IBurgerBuilder AddBun(Bun bun)
        {
            _burger.Bun = bun;
            return this;
        }

        public IBurgerBuilder AddCheese(Cheese cheese)
        {
            _burger.Cheeses.Add(cheese);
            return this;
        }

        public IBurgerBuilder AddCutlet(Cutlet cutlet)
        {
            _burger.Cutlets.Add(cutlet);
            return this;
        }

        public IBurgerBuilder AddSouce(Souce souce)
        {
            _burger.Souces.Add(souce);
            return this;
        }

        public IBurgerBuilder AddVegetable(Vegetable vegetable)
        {
            _burger.Vegetables.Add(vegetable);
            return this;
        }
        public IBurgerBuilder SetName(string name)
        {
            _burger.Name = name;
            return this;
        }
        public Burger GetBurger()
        {
            Burger cookedBurger = _burger;
            _burger = new Burger();

            return cookedBurger;
        }
    }
}
