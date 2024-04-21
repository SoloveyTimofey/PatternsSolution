using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public interface IDrawingAPI
    {
        void DrawCircle(int x, int y, int radius);
        void DrawSquare(int x, int y, int side);
    }
}
