using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricMethod.Classes;

namespace Prototype
{
    public class ChiefBurgerPrototype : BurgerPrototype
    {
        public ChiefBurgerPrototype()
        {
            Bun = new Bun(BunType.Black);
            Cutlets = new List<Cutlet>() { new Cutlet(CutletType.Beef), new Cutlet(CutletType.Beef) };
            Souce = new Souce(SouceType.ChefSpecial);
        }
        public Bun Bun { get; set; }
        public List<Cutlet> Cutlets { get; set; } = new List<Cutlet>();
        public List<Vegetable> Vegetables { get; set; } = new List<Vegetable>();
        public Souce Souce { get; set; }

        public override BurgerPrototype Clone()
        {
            return new ChiefBurgerPrototype();
        }
    }
}
