using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures
{
    class Reactangle : Shape
    {
        public Reactangle(double hight, double width)
        {
            Hight = hight;
            Width = width;
        }
        public double Hight { get; private set; }
        public double Width { get; private set; }

        public override double Area
        { 
            get { return Hight * Width; }
        }
        public override double Circumference
        {
            get { return 2 * (Hight + Width); }
        }

    }
}
