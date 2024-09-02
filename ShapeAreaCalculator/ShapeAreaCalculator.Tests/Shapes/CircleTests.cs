using ShapeAreaCalculator.Shapes;

namespace ShapeAreaCalculator.Tests.Shapes
{
    public class CircleTests
    {
        [Fact]
        public void GetArea_WithValidRadius_ReturnsExpectedArea()
        {
            // Arrange
            var circle = new Circle(5);

            // Act
            double area = circle.GetArea();

            // Assert
            Assert.Equal(Math.PI * 5 * 5, area);
        }

        [Fact]
        public void GetArea_WithInvalidRadius_ThrowsArgumentException()
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(-5));
        }
    }
}
