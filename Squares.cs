using MathS;

public static class Sqr
{
    //Square rectangle = a * b
    public static double Rect(double first_side, double second_side) { return first_side * second_side; }

    //Square area = a * a
    public static double Square(double side) { return side * side; }

    //Square triangle = a * h
    public static double Triang(double base_side, double height) { return (base_side * height) / 2; }

    //Square rTriangle = a * b
    public static double rTriang(double firsе_leg, double second_leg) { return firsе_leg * second_leg; }

    //Square trpapezoid = ((a + b) * h) / 2
    public static double Trapezoid(double first_base_side, double second_base_side, double height) { return ((first_base_side + second_base_side) * height) / 2; }

    //Square rhombus = d1 * d2
    public static double Rhomb(double first_diagonale, double second_diagonal) { return first_diagonale * second_diagonal; }
}