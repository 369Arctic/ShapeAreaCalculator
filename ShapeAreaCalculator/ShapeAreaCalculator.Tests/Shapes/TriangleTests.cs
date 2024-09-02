using ShapeAreaCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Tests.Shapes
{
    public class TriangleTests
    {
        [Fact]
        public void GetArea_ValidSides_ReturnsExpectedArea()
        {
            // Arrange 
            var triangle = new Triangle(3, 4, 5);

            // Act
            double area = triangle.GetArea();

            // Assert
            Assert.Equal(6, area);
        }

        [Fact]
        public void GetArea_InvalidSides_ThrowsArgumentException()
        { 
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 3));
        }


        [Fact]
        public void IsRightTriangle_WithSides3And4And5_ReturnsTrue()
        {
            // Arrange 
            var triangle = new Triangle(3, 4, 5);

            // Act
            bool isRightAngled = triangle.IsRightTriangle();

            // Assert
            Assert.True(isRightAngled);
        }

        [Fact]
        public void IsRightTriangle_NotRightTriangle_ReturnsFalse()
        {
            // Arrange 
            var triangle = new Triangle(2, 3, 4);

            // Act
            bool isRightAngled = triangle.IsRightTriangle();

            // Assert
            Assert.False(isRightAngled);
        }
    }
}
