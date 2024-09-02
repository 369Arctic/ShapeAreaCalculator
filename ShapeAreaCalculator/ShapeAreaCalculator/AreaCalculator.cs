using ShapeAreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator
{
    public static class AreaCalculator
    {
        public static double CalcArea(IShape shape)
        {
            return shape.GetArea();
        }
    }
}
