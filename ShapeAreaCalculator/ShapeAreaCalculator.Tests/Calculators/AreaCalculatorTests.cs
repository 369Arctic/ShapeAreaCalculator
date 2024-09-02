using ShapeAreaCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Tests.Calculators
{
    public class AreaCalculatorTests
    {
        [Fact]
        public void CalcArea_Circle_ReturnsCorrectArea()
        {
            // Arrange
            var circle = new Circle(6);

            // Act
            double area = AreaCalculator.CalcArea(circle);

            // Assert
            Assert.Equal(Math.PI * 6 * 6, area);
        }

        [Fact]
        public void CalcArea_Triangle_ReturnsCorrectArea()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act
            double area = AreaCalculator.CalcArea(triangle);

            // Assert
            Assert.Equal(6, area);
        }
    }
}

 
