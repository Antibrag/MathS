namespace MathS;

public static class Simple
{
    public const double pi = 3.14;

    //Minimal value, or string
    public static double Min(double first_num, double second_num) { return first_num < second_num ? first_num : second_num; }
    public static string Min(string first_str, string second_str) { return first_str.Length < second_str.Length ? first_str : second_str; }

    //Maxi value, or string
    public static double Max(double first_num, double second_num) { return first_num > second_num ? first_num : second_num; }
    public static string Max(string first_str, string second_str) { return first_str.Length > second_str.Length ? first_str : second_str; }

    //Perimeter
    public static double Per(double first_side, double second_side) { return (first_side + second_side) * 2; }

    //Square
    public static double Sqr(double first_side, double second_side) { return first_side * second_side; }
}