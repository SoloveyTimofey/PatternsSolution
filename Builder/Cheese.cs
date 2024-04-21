using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Cheese
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
