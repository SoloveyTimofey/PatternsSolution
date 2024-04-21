using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Classes
{
    public class CheeseBurger : Burger
    {
        public Cutlet Cutlet { get; set; }
        public List<Cheese> Cheeses { get; set; } = new List<Cheese>();
    }
}
