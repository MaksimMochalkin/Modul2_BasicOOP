using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures
{
    class Square : Shape
    {
        public Square(double side)
        {
            Side = side;
        }
        public double Side { get; private set; }
        public override double Area
        {
            get { return Side * Side; }
        }
        public override double Circumference
        {
            get { return 4 * Side; }
        }
    }
}
