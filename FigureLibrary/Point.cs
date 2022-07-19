using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Vector
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Vector(float x, float y)
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
        public float Length()
        {
            return (float)Math.Sqrt(X * X + Y * Y);
        }
        public float Distance(Vector point)
        {
            return (this - point).Length();
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
