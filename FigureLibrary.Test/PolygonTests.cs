using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Test
{
    [TestClass]
    public class PolygonTests
    {
        [TestMethod]
        public void PolygonWithThreeVerticesSquare()
        {
            FigureWithVertices figureWithVertices = new FigureWithVertices(new List<Vector> { new Vector(0, 0), new Vector(0, 2), new Vector(5, 0) });
            double result = figureWithVertices.Square();
            double excepted = 5;
            Assert.AreEqual(excepted, result);
        }
        [TestMethod]
        public void PolygonWithSixVericesSquare()
        {
            FigureWithVertices figureWithVertices = new FigureWithVertices(
                new List<Vector> 
                { 
                    new Vector(1, 1), new Vector(4, 1), new Vector(2, 5),
                    new Vector(7, 5), new Vector(3, 4), new Vector(6, 2)
                });
            double result = figureWithVertices.Square();
            double excepted = 5.5;
            Assert.AreEqual(excepted, result);
        }
        [TestMethod]
        public void TriangleName()
        {
            FigureWithVertices figureWithVertices = new FigureWithVertices(new List<Vector> { new Vector(0, 0), new Vector(0, 2), new Vector(5, 0) });
            string excepted = "Многоугольник. Фигура с произвольным количеством точек.";
            Assert.AreEqual(excepted, figureWithVertices.FigureType);
        }
    }
}
