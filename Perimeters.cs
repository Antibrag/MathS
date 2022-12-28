using MathS;

public static class Per
{
    public static double Rect(double first_side, double second_side) { return (first_side + second_side) * 2; }
    public static double Square(double side) { return side * 4; }
    public static double Polygon(double[] sides)
    {
        double result = sides[0];
        for (int i = 1; i < sides.Length; i++) result += sides[i];
        return result;
    }
}