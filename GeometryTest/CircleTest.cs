namespace GeometryTest
{
    public class CircleTest
    {
        private double eps = 1e-16;

        [Fact]
        public void NegativeRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void ZeroRadiusTest()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0));
        }

        [Fact]
        public void GetCircleRadiusTest()
        {
            var radius = 2;
            var circle = new Circle(radius);
            var area = circle.CalculateArea();
            var expectedArea = Math.PI * Math.Pow(radius, 2);

            Assert.InRange(area, expectedArea - eps, expectedArea + eps);
        }
    }
}