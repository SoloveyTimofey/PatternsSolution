using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class VintageTable : Table
    {
        public override void Put()
        {
            Console.WriteLine("You have putted something on Vintage Table");
        }
    }
}
