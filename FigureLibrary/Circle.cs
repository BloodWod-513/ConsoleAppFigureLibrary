using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Circle : Figure
    {
        public double Radius { get; set; }
        private const string defaultFigureName = "Круг";
        public Circle(double radius) : base(defaultFigureName)
        {
            Radius = radius;
        }

        public override double Square()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public string Print()
        {
            return $"Фигура: {FigureType}\n" +
                $"Радиус: {Radius}\n" +
                $"Площадь: {Square()}\n";
        }
    }
}
