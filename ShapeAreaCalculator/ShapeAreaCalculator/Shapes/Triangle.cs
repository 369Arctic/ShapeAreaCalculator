using ShapeAreaCalculator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculator.Shapes
{
    public class Triangle : IShape
    {
        public double SideAB { get; }
        public double SideBC { get; }
        public double SideAC { get; }

        public Triangle(double sideAB, double sideBC, double sideAC)
        {
            if(sideAB <= 0 || sideBC <= 0 || sideAC <= 0)
            {
                throw new ArgumentException("Все стороны треугольника должны быть больше 0");
            }

            if (sideAB + sideBC <= sideAC || sideAB + sideAC <= sideBC || sideBC + sideAC <= sideAB)
            {
                throw new ArgumentException("Создать треугольник с такими сторонами невозможно");
            }

            SideAB = sideAB;
            SideBC = sideBC;
            SideAC = sideAC;
        }

        public double GetArea()
        {
            // Вычисляем площадь треугольника по формуле Герона
            double p = (SideAB + SideBC + SideAC) / 2;
            return Math.Sqrt(p * (p - SideAB) * (p - SideBC) * (p - SideAC));
        }

        public bool IsRightTriangle()
        {
            // Метод для проверки является ли треугольник прямоугольным с помощью теоремы Пифагора:
            // квадрат гипотенузы равен квадрату катетов
            double[] sides = { SideAB, SideBC, SideAC };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);

        }
    }
}
