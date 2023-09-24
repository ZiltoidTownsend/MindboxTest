using MindboxTest.Domain.Shapes;

namespace MindboxTest.Tests.Domain.Shapes;

public class TriangleTest
{
    [Fact]
    public void IsRectangular_EgyptTriangle_True()
    {
        Triangle triangle = new Triangle(3, 4, 5);

        var result = triangle.IsRectangular();

        Assert.True(result);
    }
    [Fact]
    public void IsRectangular_AllTwo_False()
    {
        Triangle triangle = new Triangle(2, 2, 2);

        var result = triangle.IsRectangular();

        Assert.False(result);
    }
    [Fact]
    public void GetArea_EgyptTriangle_Six()
    {
        Triangle triangle = new Triangle(3, 4, 5);

        var result = triangle.GetArea();

        Assert.Equal(6, result);
    }
    [Fact]
    public void GetArea_NegativeValues_Exception()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-3, -4, -5));
    }
}
