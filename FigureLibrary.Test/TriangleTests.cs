namespace FigureLibrary.Test
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleWithSidesSquare()
        {
            TriangleWithSides triangleWithSides = new TriangleWithSides(15, 14, 13);
            double result = triangleWithSides.Square();
            double excepted = 84;
            Assert.AreEqual(excepted, result);
        }
        [TestMethod]
        public void TriangleWithVericesSquare()
        {
            TriangleWithVertices triangleWithVertices = new TriangleWithVertices(new Vector(0, 0), new Vector(1, 2), new Vector(2, 0));
            double result = triangleWithVertices.Square();
            double exceped = 2;
            Assert.AreEqual(exceped, result);
        }
        [TestMethod]
        public void IsStraightTriange()
        {
            TriangleWithVertices straightAngleTriangle = new TriangleWithVertices(new Vector(0, 0), new Vector(0, 2), new Vector(5, 0));
            Assert.IsTrue(straightAngleTriangle.IsStraightAngleTriangle());
        }
        [TestMethod]
        public void TriangleName()
        {
            TriangleWithSides triangleWithSides = new TriangleWithSides(15, 14, 13);
            string excepted = "Треугольник";
            Assert.AreEqual(excepted, triangleWithSides.FigureType);
        }
    }
}