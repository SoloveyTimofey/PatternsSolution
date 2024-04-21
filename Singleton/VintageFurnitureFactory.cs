using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class VintageFurnitureFactory : FurnitureFactory
    {
        private static VintageFurnitureFactory _instanse;
        private VintageFurnitureFactory() { }

        public override Chair CreateChair()=>new VintageChair();

        public override Table CreateTable() => new VintageTable();

        public static FurnitureFactory GetInstanse()
        {
            if (_instanse == null)
            {
                _instanse = new VintageFurnitureFactory();
            }
            return _instanse;
        }
    }
}
