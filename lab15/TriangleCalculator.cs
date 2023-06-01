using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    public class TriangleCalculator
    {
        public static double CalculateHypotenuse(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }

        public static double CalculateArea(double a, double b)
        {
            return a * b / 2;
        }
    }

}
