﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Circle
    {
        private int Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }

        public void DrawCircle()
        {
            Console.WriteLine($"Circle has a circumference {2*3.14*Radius}");
        }
    }
}
