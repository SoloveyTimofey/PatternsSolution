using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Classes
{
    public class Cheese :BurgerComponent
    {
        public CheeseType Type { get; set; }
        public Cheese(CheeseType cheeseType) 
        {
            Type = cheeseType;
        }
    }

    public enum CheeseType
    {
        Cheddar,
        Gouda,
        Goat
    }
}
