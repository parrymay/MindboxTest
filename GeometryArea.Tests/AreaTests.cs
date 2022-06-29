using Geometry;

namespace GeometryArea.Tests
{
    public class AreaTests
    {
        [Fact]
        public void Circle_0_0returned()
        {
            double r = 0;
            double expected = 0;

            var area = Area.Circle(r);

            Assert.Equal(expected, area);
        }
        [Fact]
        public void Circle_LessThenZero_ThrowsArgumentException()
        {
            double r = -1;
            ArgumentException expected = new("Radius can't be less than 0"); ;

            Action act = () => Area.Circle(r);

            Assert.Throws<ArgumentException>(act);
        }
        [Fact]
        public void Circle_10_314returned()
        {
            double r = 10;
            double expected = 314.1592653589793;

            var area = Area.Circle(r);

            Assert.Equal(expected, area);
        }
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(5, 10, 12, 24.544602257930357)]
        public void Triangle_Passed(double sideA, double sideB, double sideC, double expected)
        {
            var area = Area.Triangle(sideA, sideB, sideC);

            Assert.Equal(expected, area);
        }

        [Fact]
        public void Triangle_3_4_LessThanZero_ThrowsArgumentException()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = -1;
            ArgumentException expected = new("Side of a triangle can't be 0 or less"); ;

            Action act = () => Area.Triangle(sideA, sideB, sideC);

            Assert.Throws<ArgumentException>(act);
        }

        public void Triangle_3_4_12_ThrowsArgumentException()
        {
            double sideA = 3;
            double sideB = 4;
            double sideC = 12;
            ArgumentException expected = new("Triangle no exist"); ;

            Action act = () => Area.Triangle(sideA, sideB, sideC);

            Assert.Throws<ArgumentException>(act);
        }

        public void Triangle_0_0_0_ThrowsArgumentException()
        {
            double sideA = 0;
            double sideB = 0;
            double sideC = 0;
            ArgumentException expected = new("Triangle no exist"); ;

            Action act = () => Area.Triangle(sideA, sideB, sideC);

            Assert.Throws<ArgumentException>(act);
        }
    }
}