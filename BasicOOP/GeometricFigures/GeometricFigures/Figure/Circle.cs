using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures
{
    class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Radius { get; private set; }

        public override double Area
        {
            get { return Math.PI * Radius * Radius; }
        }
        public override double Circumference
        {
            get { return Math.PI * 2 * Radius; }
        }
    }
}
