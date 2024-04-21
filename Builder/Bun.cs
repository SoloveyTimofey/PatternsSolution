using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Bun
    {
        public BunType Type;
        public Bun(BunType bunType)
        {
            Type = bunType;
        }
    }

    public enum BunType
    {
        Wheat,
        Rye,
        Black
    }
}
