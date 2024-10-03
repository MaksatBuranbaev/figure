using AreaFigures;

namespace AreaFiguresTests;

[TestClass]
public class CircleTests
{
    [TestMethod]
    public void PositiveTest()
    {
        var r = 5;
        var s = 25 * Math.PI;
        // Вычисление площади фигуры без знания типа фигуры в compile-time
        // мы ожидаем что это у обьекта можно посчитать площадь, остальное нам не важно
        IArea circle = new Circle(r);
        var exp = circle.CalculatingArea();

        Assert.AreEqual(exp, s);
    }

    [TestMethod]
    public void NegativeTest()
    {
        var r = 5;
        var s = 0;
        var circle = new Circle(r);
        var exp = circle.CalculatingArea();

        Assert.AreNotEqual(exp, s);
    }
}