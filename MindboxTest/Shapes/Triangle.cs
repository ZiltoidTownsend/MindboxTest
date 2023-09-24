namespace MindboxTest.Domain.Shapes;

public class Triangle : IShape
{
    private readonly double _sideA;
    private readonly double _sideB;
    private readonly double _sideC;
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0)
            throw new ArgumentOutOfRangeException(nameof(sideA), "Число должно быть положительным и не равным нулю");
        if (sideB <= 0)
            throw new ArgumentOutOfRangeException(nameof(sideB), "Число должно быть положительным и не равным нулю");
        if (sideC <= 0)
            throw new ArgumentOutOfRangeException(nameof(sideC), "Число должно быть положительным и не равным нулю");

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }
    public double GetArea()
    {
        var halfPerimeter = (_sideA + _sideB + _sideC) / 2;

        return Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));
    }
    public bool IsRectangular() =>
        _sideA * _sideA == _sideB * _sideB + _sideC * _sideC ||
        _sideB * _sideB == _sideA * _sideA + _sideC * _sideC ||
        _sideC * _sideC == _sideA * _sideA + _sideB * _sideB;
}
