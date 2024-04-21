using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ModernChair : Chair
    {
        public override void Sit()
        {
            Console.WriteLine("You have sitted on Modern Chair.");
        }
    }
}
