using ShapeAreaCalculator.Interfaces;

namespace ShapeAreaCalculator.Shapes
{
    public class Circle : IShape
    {
        // Отсутствие сеттера обусловлено неизменяемостью радиуса объекта после его создания.
        // Если необходимо добавить возможность изменять радиус объекта после создания - нужно добавить сеттер.
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть больше 0");
            }
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI* Radius * Radius;
        }
    }
}
