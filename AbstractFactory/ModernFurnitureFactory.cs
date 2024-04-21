using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ModernFurnitureFactory : FurnitureFactory
    {
        public override Chair CreateChair()=>new ModernChair();

        public override Table CreateTable()=>new ModernTable();
    }
}
