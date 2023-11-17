using GeometryLib.Interfaces;

namespace GeometryLib
{
    public class Triangle : ITriangle
    {
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        private readonly bool _isRightTriangle;
        public bool IsRightTriangle { get { return _isRightTriangle; } }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
                throw new ArgumentException("Неверно указана сторона A");
            if (sideB <= 0)
                throw new ArgumentException("Неверно указана сторона B");
            if (sideC <= 0)
                throw new ArgumentException("Неверно указана сторона C");

            if ((sideA + sideB <= sideC) || (sideA + sideC <= sideB) || (sideB + sideC <= sideA))
                throw new ArgumentException("Сумма любых двух сторон треугольника всегда должна быть больше третьей стороны");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            _isRightTriangle = GetIsRightTriangle();
        }

        public double CalculateArea()
        {
            var halfP = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(halfP * (halfP - SideA) * (halfP - SideB) * (halfP - SideC));
        }

        public bool GetIsRightTriangle()
        {
            return (SideA * SideA) + (SideB * SideB) == (SideC * SideC) || (SideA * SideA) + (SideC * SideC) == (SideB * SideB) || (SideC * SideC) + (SideB * SideB) == (SideA * SideA);
        }
    }
}