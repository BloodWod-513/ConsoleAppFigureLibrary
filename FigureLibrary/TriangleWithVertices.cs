using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class TriangleWithVertices : Triangle
    {
        public Vector PointA
        {
            get => pointA;
            set
            {
                pointA = value;
                SetLengths();
            }
        }
        public Vector PointB
        {
            get => pointB;
            set
            {
                pointB = value;
                SetLengths();
            }
        }
        public Vector PointC
        {
            get => pointC;
            set
            {
                pointC = value;
                SetLengths();
            }
        }
        private Vector pointA;
        private Vector pointB;
        private Vector pointC;
        public TriangleWithVertices(Vector pointA, Vector pointB, Vector pointC)
        {
            PointA = pointA;
            PointB = pointB;
            PointC = pointC;
            SetLengths();
            MakeTriangle();
        }
        public override string Print()
        {
            return $"Фигура: {FigureType} с вершинами\n" +
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
            if (pointA == null || pointB == null || pointC == null)
                return;
            A = PointA.Distance(PointB);
            B = PointA.Distance(PointC);
            C = PointB.Distance(PointC);
        }
    }
}
