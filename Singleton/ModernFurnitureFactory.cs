using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ModernFurnitureFactory : FurnitureFactory
    {
        private static ModernFurnitureFactory _instance;
        private ModernFurnitureFactory() { }        

        public override Chair CreateChair()=>new ModernChair();

        public override Table CreateTable()=>new ModernTable();

        public static FurnitureFactory GetInstanse()
        {
            if(_instance == null)
            {
                _instance = new ModernFurnitureFactory();
            }
            return _instance;
        }
    }
}
