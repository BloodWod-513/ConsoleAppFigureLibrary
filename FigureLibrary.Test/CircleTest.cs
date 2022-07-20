using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary.Test
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleSquare()
        {
            Circle circle = new(5);
            double result = Math.Round(circle.Square(), 0);
            double excepted = Math.Round(78.53981, 0);
            Assert.AreEqual(excepted, result);
        }
        [TestMethod]
        public void CircleName()
        {
            Circle circle = new Circle(5);
            string excepted = "Круг";
            Assert.AreEqual(excepted, circle.FigureType);
        }
    }
}
