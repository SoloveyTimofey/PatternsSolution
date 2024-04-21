using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Circle : Shape
    {
        private int x, y, radius;
        public Circle(int x, int y, int radius,IDrawingAPI drawingAPI):base(drawingAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            drawingAPI.DrawCircle(x,y, radius);
        }
    }
}
