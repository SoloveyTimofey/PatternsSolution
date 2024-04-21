using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICircle shape = new CircleAdapter(20);

            shape.Draw();

            Console.ReadLine();
        }
    }
}
