namespace AreaFigures;

public class Circle(double r): IArea 
{
    private double Radius { get; set; } = r;

    public double CalculatingArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
