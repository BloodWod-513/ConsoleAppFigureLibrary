using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class FigureWithVertices : Figure, IPrint
    {
        private List<Vector> vectors = new List<Vector>();
        private const string defaultFigureName = "Многоугольник. Фигура с произвольным количеством точек.";

        public List<Vector> Vectors { get => vectors; set => vectors = value; }

        public FigureWithVertices(List<Vector> vectors) : base(defaultFigureName)
        {
            Vectors = vectors;
        }

        public string Print()
        {
            string str = $"Фигура: {FigureType} с вершинами\n" +
                $"Площадь треугольника: {Square()}\n";

            for (int i = 0; i < vectors.Count; i++)
            {
                str += $"Вершина {i}: {vectors[i]}\n";
            }

            return str;
        }

        public override double Square()
        {
            double temp = 0;
            for (int i = 0; i < vectors.Count - 1; i++)
            {
                temp += vectors[i].X * vectors[i + 1].Y - vectors[i].Y * vectors[i + 1].X;
            }
            temp += vectors[^1].X * vectors[0].Y - vectors[^1].Y * vectors[0].X;
            return temp < 0 ? -temp / 2 : temp / 2;
        }
    }
}
