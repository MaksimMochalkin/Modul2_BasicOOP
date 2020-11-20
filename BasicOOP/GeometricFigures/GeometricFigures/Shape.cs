using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricFigures
{
    class Shape
    {
        public virtual double Area
        {
            get { return 0.0; }
        }
        public virtual double Circumference
        {
            get { return 0.0; }
        }
    }
}
