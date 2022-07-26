﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class TriangleWithSides : Triangle, IPrint
    {
        public TriangleWithSides(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
            TryMakeTriangle();
        }
        public void SetA(double a)
        {
            A = a;
        }
        public void SetB(double b)
        {
            B = b;
        }
        public void SetC(double c)
        {
            C = c;
        }
        public string Print()
        {
            return $"Фигура: {FigureType} без вершин\n" +
                $"Площадь треугольника: {Square()}\n" +
                $"Сторона A: {A}\n" +
                $"Сторона B: {B}\n" +
                $"Сторона C: {C}\n";
        }
    }
}
