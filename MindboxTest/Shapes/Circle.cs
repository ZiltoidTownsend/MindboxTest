namespace MindboxTest.Domain.Shapes;

public class Circle : IShape
{
    private readonly double _radius;
    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Число должно быть положительным и не равным нулю");
        
        _radius = radius;
    }

    public double GetArea() => Math.PI * _radius * _radius;
}
