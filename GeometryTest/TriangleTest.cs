using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryTest
{
    public class TriangleTest
    {
        private double eps = 1e-16;

        [Fact]
        public void NegativeSideTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-6,4,9));
        }

        [Fact]
        public void ZeroSideTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 9));
        }

        [Fact]
        public void InvalidTriangleTest()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(8, 3, 4));
        }

        [Fact]
        public void GetAreaTest()
        {
            var triangle = new Triangle(6, 4, 9);
            var area = triangle.CalculateArea();

            var halfP = 9.5;
            var expectedArea = Math.Sqrt(halfP * (halfP - 6) * (halfP - 4) * (halfP - 9));

            Assert.InRange(area, expectedArea - eps, expectedArea + eps);
        }

        [Fact]
        public void RightTriangleTest()
        {
            var isRight = new Triangle(3, 4, 5).GetIsRightTriangle();

            Assert.True(isRight);
        }

        [Fact]
        public void NotRightTriangleTest()
        {
            var isRight = new Triangle(3, 4, 6).GetIsRightTriangle();

            Assert.False(isRight);
        }
    }
}
