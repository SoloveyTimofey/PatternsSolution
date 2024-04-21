using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Classes
{
    public class ChiefBurger : Burger
    {
        public List<Cutlet> Cutlets { get; set; } = new List<Cutlet>();
        public List<Vegetable> Vegetables { get; set; } = new List<Vegetable>();
        public Souce Souce { get; set; }
    }
}
