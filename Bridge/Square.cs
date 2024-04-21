using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Square : Shape
    {
        private int x, y, side;
        public Square(int x, int y, int side, IDrawingAPI drawingAPI) : base(drawingAPI)
        {
            this.x = x;
            this.y = y;
            this.side = side;
        }

        public override void Draw()
        {
            drawingAPI.DrawSquare(x, y, side);
        }
    }
}
