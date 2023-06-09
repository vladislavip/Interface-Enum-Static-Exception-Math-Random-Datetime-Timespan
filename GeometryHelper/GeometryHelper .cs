using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryHelper
{
    internal static class GeometryHelper
    {
        public  static double CalculateRectangleArea(double side1, double side2)
        {
            double area = side1 * side2;
            return area;
        }

        public static double CalculateTriangleArea (double Base, double height) 
        {
            double area = 0.5*Base*height; 
            return area;
        }

        public  static double CalculateCircleArea(double radius)
        {
            double area = Math.PI *Math.Pow(radius, 2); 
            return area;
        }
    }
}
