using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.AbstractFactory
{
    public class PrinterDrawingAPIFactory : DrawingAPIFactory
    {
        public override IDrawingAPI GetFrawingAPI()=>new PrinterDrawingAPI();
    }
}
