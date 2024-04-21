using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ScreenDrawingAPI : IDrawingAPI
    {
        public void DrawCircle(int x, int y, int radius)
        {
            Console.WriteLine($"Circle with coordinates x={x};y={y} and radius={radius} was drawn on Screen.");
        }

        public void DrawSquare(int x, int y, int side)
        {
            Console.WriteLine($"Square with coordinates x={x};y={y} and side={side} was drawn on Screen.");
        }
    }
}
