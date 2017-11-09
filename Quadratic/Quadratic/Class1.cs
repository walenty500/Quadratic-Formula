using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solve
{
    class QuadraticEquation
    {
        public double a, b, c;

        public QuadraticEquation()
        {
            a = 1;
            b = 1;
            c = 1;
        }

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double calculateDelta()
        {
            double delta = b * b - 4 * a * c;
            return delta;
        }

        public double calculateX1()
        {
            double delta = b * b - 4 * a * c;
                double root1 = (-b + Math.Sqrt(delta)) / 2 * a;
                return root1;
        }

        public double calculateX2()
        {
            double delta = b * b - 4 * a * c;
                double root2 = (-b - Math.Sqrt(delta)) / 2 * a;
                return root2;
        }
    }
}
