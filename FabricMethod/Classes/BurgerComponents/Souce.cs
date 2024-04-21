using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Classes
{
    public class Souce : BurgerComponent
    {
        public SouceType Type { get; set; }
        public Souce(SouceType souceType) 
        { 
            Type = souceType;
        }
    }

    public enum SouceType
    {
        Ketchup,
        Mayonnaise,
        ChefSpecial
    }
}
