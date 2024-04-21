using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FabricMethod.Classes;

namespace Prototype
{
    public abstract class BurgerPrototype
    {
        public abstract BurgerPrototype Clone();
    }
}
