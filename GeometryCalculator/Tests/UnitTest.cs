namespace Tests;

using GeometryCalculator;

public class GeometryCalculatorTests
{
    #region Volume

    [Test]
    [TestCase(3, 2, 1.5, ExpectedResult = 37.69911184307752)]
    [TestCase(3, 1.5, 1.5, ExpectedResult = 28.274333882308138)]
    [TestCase(1.5, 1.5, 3, ExpectedResult = 28.274333882308138)]
    [TestCase(2, 2, 2, ExpectedResult = 33.510321638291124)]
    public double VolumeGotCorrectValues(double a, double b, double c)
    {
        return Ellipsoid.volume(a, b, c);
    }

    [Test]
    [TestCase(-3, 2, 1.5)]
    [TestCase(3, -2, 1.5)]
    [TestCase(3, 2, -1.5)]
    [TestCase(-3, -2, 1.5)]
    [TestCase(3, -2, -1.5)]
    [TestCase(-3, 2, -1.5)]
    [TestCase(-3, -2, -1.5)]
    [TestCase(-3, 1.5, 1.5)]
    [TestCase(3, -1.5, 1.5)]
    [TestCase(3, 1.5, -1.5)]
    [TestCase(-3, -1.5, 1.5)]
    [TestCase(3, -1.5, -1.5)]
    [TestCase(-3, 1.5, -1.5)]
    [TestCase(-3, -1.5, -1.5)]
    [TestCase(-2, 2, 2)]
    [TestCase(2, -2, 2)]
    [TestCase(2, 2, -2)]
    [TestCase(-2, -2, 2)]
    [TestCase(2, -2, -2)]
    [TestCase(-2, 2, -2)]
    [TestCase(-2, -2, -2)]
    public void VolumeGotNegativeParameter(double a, double b, double c)
    {
        var result = Ellipsoid.volume(a, b, c);
        Assert.IsNaN(result);
    }

    #endregion

    #region Area

    [Test]
    [TestCase(3, 2, 1.5, ExpectedResult = 58.60600913268703)]
    [TestCase(3, 1.5, 1.5, ExpectedResult = 48.326479487738396)]
    [TestCase(1.5, 1.5, 3, ExpectedResult = 48.326479487738396)]
    [TestCase(2, 2, 2, ExpectedResult = 50.26548245743669)]
    public double AreaGotCorrectValues(double a, double b, double c)
    {
        return Ellipsoid.area(a, b, c);
    }

    [Test]
    [TestCase(-3, 2, 1.5)]
    [TestCase(3, -2, 1.5)]
    [TestCase(3, 2, -1.5)]
    [TestCase(-3, -2, 1.5)]
    [TestCase(3, -2, -1.5)]
    [TestCase(-3, 2, -1.5)]
    [TestCase(-3, -2, -1.5)]
    [TestCase(-3, 1.5, 1.5)]
    [TestCase(3, -1.5, 1.5)]
    [TestCase(3, 1.5, -1.5)]
    [TestCase(-3, -1.5, 1.5)]
    [TestCase(3, -1.5, -1.5)]
    [TestCase(-3, 1.5, -1.5)]
    [TestCase(-3, -1.5, -1.5)]
    [TestCase(-2, 2, 2)]
    [TestCase(2, -2, 2)]
    [TestCase(2, 2, -2)]
    [TestCase(-2, -2, 2)]
    [TestCase(2, -2, -2)]
    [TestCase(-2, 2, -2)]
    [TestCase(-2, -2, -2)]
    public void AreaGotNegativeParameter(double a, double b, double c)
    {
        var result = Ellipsoid.area(a, b, c);
        Assert.IsNaN(result);
    }


    [Test]
    [TestCase(2, 3, 1.5)]
    [TestCase(2, 1.5, 3)]
    [TestCase(3, 1.5, 2)]
    [TestCase(1.5, 3, 2)]
    [TestCase(1.5, 2, 3)]
    [TestCase(1.5, 3, 1.5)]
    public void AreaGotParametersWithWrongOrder(double a, double b, double c)
    {
        var result = Ellipsoid.area(a, b, c);
        Assert.IsNaN(result);
    }

    #endregion
}