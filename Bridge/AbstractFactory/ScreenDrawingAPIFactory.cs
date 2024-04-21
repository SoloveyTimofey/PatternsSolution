using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.AbstractFactory
{
    internal class ScreenDrawingAPIFactory : DrawingAPIFactory
    {
        public override IDrawingAPI GetFrawingAPI()=>new ScreenDrawingAPI();
    }
}
