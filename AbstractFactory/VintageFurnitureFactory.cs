using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class VintageFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()=>new VintageChair();

        public override Table CreateTable() => new VintageTable();
    }
}
