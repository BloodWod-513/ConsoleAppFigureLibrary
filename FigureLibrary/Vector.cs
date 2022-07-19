using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public static Vector operator +(Vector pointA, Vector pointB)
        {
            return new Vector(pointA.X + pointB.X, pointA.Y + pointB.Y);
        } 
        public static Vector operator -(Vector pointA, Vector pointB)
        {
            return new Vector(pointA.X - pointB.X, pointA.Y - pointB.Y);
        }
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public double Distance(Vector point)
        {
            return (this - point).Length();
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
