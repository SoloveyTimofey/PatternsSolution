using Bridge.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                DrawingAPIFactory factory = DrawingAPIFactory.GetInstanse();

                IDrawingAPI drawingAPI = factory.GetFrawingAPI();

                drawingAPI.DrawSquare(10, -20, 5);
                drawingAPI.DrawCircle(20, 7, 3);

                Console.ReadLine();
            }
        }
    }
}
