using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethod.Classes
{
    public class Cutlet : BurgerComponent
    {
        public CutletType Type { get; set; }
        public Cutlet(CutletType cutletType) 
        {
            Type = cutletType;
        }
    }

    public enum CutletType
    {
        Beef,
        Chiken,
        Turkey
    }
}
