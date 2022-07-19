using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Triangle : Figure
    {
        public Vector PointA { get; private set; }
        public Vector PointB { get; private set; }
        public Vector PointC { get; private set; }
        public double A
        {
            get => a;
            set => a = value;
        }

        public double B
        {
            get => b;
            set => b = value;
        }
        public double C
        {
            get => c;
            set => c = value;
        }
        public bool HasVertices { get; protected set; }
        private double a;
        private double b;
        private double c;
        private const string defaultFigureName = "Треугольник";
        public Triangle(Vector pointA, Vector pointB, Vector pointC) : base(defaultFigureName)
        {
            PointA = pointA;
            PointB = pointB;
            PointC = pointC;
            HasVertices = true;
            MakeTriangle(HasVertices);
        }
        public Triangle(double a, double b, double c) : base(defaultFigureName)
        {
            A = a;
            B = b;
            C = c;
            HasVertices = false;
            MakeTriangle(HasVertices);
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
        public string Print()
        {
            return $"Фигура: {FigureType}\n" +
                $"Площадь треугольника: {Square()}\n" +
                $"Точка 1: {PointA}\n" +
                $"Точка 2: {PointB}\n" +
                $"Точка 3: {PointC}\n" +
                $"Сторона A: {A}\n" +
                $"Сторона B: {B}\n" +
                $"Сторона C: {C}\n";
        }
        private void SetLengths()
        {
            a = PointA.Distance(PointB);
            b = PointA.Distance(PointC);
            c = PointB.Distance(PointC);
        }
        private void MakeTriangle(bool withVertices)
        {
            if (withVertices) SetLengths();
            IsExsist();
            if (IsStraightAngleTriangle())
                FigureType = "Прямоугольный треугольник";
        }
    }
}
