using GeometryLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Circle : ICircle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Неверно указан радиус окружности");

            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }
    }
}
