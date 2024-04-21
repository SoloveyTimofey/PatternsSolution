using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Souce
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
