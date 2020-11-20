using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures
{
    class Triangle : Shape
    {
        public Triangle(double side1, double side2, double hypotenuse)
        {
            Side1 = side1;
            Side2 = side2;
            Hypotenuse = hypotenuse;
        }

        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Hypotenuse { get; private set; }


        public override double Area
        {
            get
            {
                double p = (Side1 + Side2 + Hypotenuse) / 2;
                double c = p * (p - Side1) * (p - Side2) * (p - Hypotenuse);
                return Math.Sqrt(c);
            }

        }
        public override double Circumference
        {
            get { return Side1 + Side2 + Hypotenuse; }
        }
    }
}
