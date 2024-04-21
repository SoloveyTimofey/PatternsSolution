using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class VintageChair : Chair
    {
        public override void Sit()
        {
            Console.WriteLine("You have sitted on Vintage Chair.");
        }
    }
}
