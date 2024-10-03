namespace AreaFigures;

public class Triangle(double a, double b, double c): IArea 
{
    private double A { get; set; } = a;
    private double B { get; set; } = b;
    private double C { get; set; } = c;

    private static bool Check(double first, double second, double third)
    {
        if (Math.Abs(Math.Pow(first, 2) * Math.Pow(second, 2) - Math.Pow(third, 2)) < 0.001)
        {
            return true;
        }
        return false;
    }
    public double CalculatingArea()
    {
        if (Check(A, B, C))
        {
            return A * B / 2;
        }
        else if(Check(A, C, B))
        {
            return A * C / 2;
        }
        else if(Check(B, C, A))
        {
            return B * C / 2;
        }
        else
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
