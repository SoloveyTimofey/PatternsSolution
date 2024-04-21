using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Bridge.AbstractFactory
{
    public abstract class DrawingAPIFactory
    {
        private static DrawingAPIFactory instance;
        protected DrawingAPIFactory() { }

        public static DrawingAPIFactory GetInstanse()
        {
            string targetDevice = ConfigurationManager.AppSettings["TargetDevice"];

            if (targetDevice == "Printer")
            {
                instance = new PrinterDrawingAPIFactory();
            }
            else if(targetDevice =="Screen")
            {
                instance = new ScreenDrawingAPIFactory();
            }
            else
            {
                throw new NotSupportedException($"{targetDevice} is not supported");
            }

            return instance;
        }

        public abstract IDrawingAPI GetFrawingAPI();
    }
}
