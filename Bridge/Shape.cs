using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Shape
    {
        protected IDrawingAPI drawingAPI;
        protected Shape(IDrawingAPI drawingAPI)
        {
            this.drawingAPI = drawingAPI;
        }

        public abstract void Draw();
    }
}
