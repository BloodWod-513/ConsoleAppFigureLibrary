﻿using FigureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFigureLibrary
{
    public class Program
    {
        static void Main()
        {
            Triangle triangle = new Triangle(new Vector(0, 0), new Vector(1, 2), new Vector(2, 0));
            Console.WriteLine(triangle.Print());
            Triangle straightAngleTriangle = new Triangle(new Vector(0, 0), new Vector(0, 2), new Vector(5, 0));
            Console.WriteLine(straightAngleTriangle.Print());
            Triangle triangleWithoutVertices = new Triangle(5, 2, 6);
            Console.WriteLine(triangleWithoutVertices.Print());
            Console.ReadKey();
        }
    }
}
