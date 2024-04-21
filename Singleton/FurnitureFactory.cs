using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public abstract class FurnitureFactory
    {

        //public static FurnitureFactory GetInstanse<T>() where T : FurnitureFactory
        //{
        //    if (_instanse == null)
        //    {
        //        if (typeof(T) == typeof(VintageFurnitureFactory))
        //        {
        //            _instanse = new VintageFurnitureFactory();
        //        }
        //        else if (typeof(T) == typeof(ModernFurnitureFactory))
        //        {
        //            _instanse = new ModernFurnitureFactory();
        //        }
        //        else
        //        {
        //            throw new Exception("Unknown type of FurnitureFactory");
        //        }
        //    }
        //    return _instanse;
        //}
        public abstract Table CreateTable();
        public abstract Chair CreateChair();
    }
}
