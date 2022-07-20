using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public abstract class Triangle : Figure
    {
        public double A
        {
            get => a;
            protected set => a = value;
        }

        public double B
        {
            get => b;
            protected set => b = value;
        }
        public double C
        {
            get => c;
            protected set => c = value;
        }
        private double a;
        private double b;
        private double c;
        private const string defaultFigureName = "Треугольник";

        protected Triangle() : base(defaultFigureName)
        {
        }
        public void IsExsist()
        {
            if (A <= 0 || B <= 0 || C <= 0)
            {
                throw new ArgumentException("Одна из трех сторон меньше нуля. Такого треугольника не существует.");
            }
            else if (B + C <= A && B + A <= C && A + C <= B)
            {
                throw new ArgumentException("Сторона одной стороны больше суммы двух других сторон. Такого треугольника не существует.");
            }
        }
        public bool IsStraightAngleTriangle()
        {
            return (A == Math.Sqrt(B * B + C * C) || B == Math.Sqrt(A * A + C * C) || C == Math.Sqrt(A * A + B * B));
        }
        public override double Square()
        {
            double semiPerimeter = (A + B + C) / 2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C));
        }
        protected void TryMakeTriangle()
        {
            IsExsist();
            if (IsStraightAngleTriangle())
                FigureType = "Прямоугольный треугольник";
        }
    }
}
