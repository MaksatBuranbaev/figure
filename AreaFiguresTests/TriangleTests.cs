using AreaFigures;

namespace AreaFiguresTests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void PositiveTest()
    {
        var a = 5;
        var b = 7;
        var c = 9;
        var s = 17.4123;
        var triangle = new Triangle(a, b, c);
        var exp = triangle.CalculatingArea();
        Assert.AreEqual(exp, s, 0.001);
    }

    [TestMethod]
    public void NegativeTest()
    {
        var a = 5;
        var b = 7;
        var c = 9;
        var s = 0;
        var triangle = new Triangle(a, b, c);
        var exp = triangle.CalculatingArea();
        Assert.AreNotEqual(exp, s, 0.001);
    }

    [TestMethod]
    public void RectangularTest()
    {
        var a = 3;
        var b = 4;
        var c = 5;
        var s = 6;
        var triangle = new Triangle(a, b, c);
        var exp = triangle.CalculatingArea();
        Assert.AreEqual(exp, s);
    }
}