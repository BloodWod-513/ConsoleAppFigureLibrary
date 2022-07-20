using FigureLibrary;
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
            TriangleWithVertices triangle = new TriangleWithVertices(new Vector(0, 0), new Vector(1, 2), new Vector(2, 0));
            Console.WriteLine(triangle.Print());
            TriangleWithVertices straightAngleTriangle = new TriangleWithVertices(new Vector(0, 0), new Vector(0, 2), new Vector(5, 0));
            Console.WriteLine(straightAngleTriangle.Print());
            TriangleWithSides triangleWithoutVertices = new TriangleWithSides(5, 2, 6);
            Console.WriteLine(triangleWithoutVertices.Print());
            Circle circle = new Circle(5);
            Console.WriteLine(circle.Print());
            Figure figure = triangle;
            Console.WriteLine("compiled time " + Figure.Square(triangle));
            Console.WriteLine(figure.Square());
            Figure figureCircle = circle;
            Console.WriteLine(figureCircle.Square());
            FigureWithVertices figureWithVertices = new FigureWithVertices(new List<Vector> { new Vector(0, 0), new Vector(0, 2), new Vector(5, 0) });
            Console.WriteLine(figureWithVertices.Print());
            Console.ReadKey();
        }
    }
}
