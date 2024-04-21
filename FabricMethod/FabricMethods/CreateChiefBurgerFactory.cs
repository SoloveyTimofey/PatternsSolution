using FabricMethod.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.FabricMethods
{
    public class CreateChiefBurgerFactory : IBurgerFactory
    {
        public Burger CreateBurger() => new ChiefBurger()
        {
            BunType = new Bun(BunType.Black),
            Cutlets = new List<Cutlet>() { new Cutlet(CutletType.Beef), new Cutlet(CutletType.Beef)},
            Souce = new Souce(SouceType.ChefSpecial)
        };
    }
}
