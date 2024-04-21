using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class CircleAdapter : MockCircle, ICircle
    {
        public CircleAdapter(int radius) : base(radius)
        {
        }

        public void Draw()
        {
            base.DrawCircle();
        }
    }
}
