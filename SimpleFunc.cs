namespace MathS;

public static class Simple
{
    //Returns the minimum between two numbers, to return the smallest value between more arguments - use Simple.Sort()
    public static double Min(double first_num, double second_num) { return first_num < second_num ? first_num : second_num; }

    //Returns the minimum between three numbers, to return the smallest value between more arguments - use Simple.Sort()
    public static double Min(double first_num, double second_num, double third_num)
    {
        double[] num_array = new double[3] { first_num, second_num, third_num };
        double minimal = first_num;
        for (int i = 1; i < num_array.Length; i++) if (minimal > num_array[i]) minimal = num_array[i];
        return minimal;
    }

    //Returns a string with fewer characters, to return the smallest string by passing more strings as arguments - use Simple.Sort()
    public static string Min(string first_str, string second_str) { return first_str.Length < second_str.Length ? first_str : second_str; }

    //Returns a string with fewer characters, to return the smallest string by passing more strings as arguments - use Simple.Sort()
    public static string Min(string first_str, string second_str, string third_str)
    {
        string[] num_array = new string[3] { first_str, second_str, third_str };
        string minimal = first_str;
        for (int i = 1; i < num_array.Length; i++) if (minimal.Length > num_array[i].Length) minimal = num_array[i];
        return minimal;
    }

    //Returns the greatest between two numbers, to return the highest value between more arguments - use Simple.Sort()
    public static double Max(double first_num, double second_num) { return first_num > second_num ? first_num : second_num; }

    //Returns the greatest between three numbers, to return the highest value between more arguments - use Simple.Sort()
    public static double Max(double first_num, double second_num, double third_num)
    {
        double[] num_array = new double[3] { first_num, second_num, third_num };
        double highest = first_num;
        for (int i = 1; i < num_array.Length; i++) if (highest < num_array[i]) highest = num_array[i];
        return highest;
    }

    //Returns a string with greatest characters, to return the highest string by passing more strings as arguments - use Simple.Sort()
    public static string Max(string first_str, string second_str) { return first_str.Length > second_str.Length ? first_str : second_str; }

    //Returns a string with greatest characters, to return the highest string by passing more strings as arguments - use Simple.Sort()
    public static string Max(string first_str, string second_str, string third_str)
    {
        string[] num_array = new string[3] { first_str, second_str, third_str };
        string highest = first_str;
        for (int i = 1; i < num_array.Length; i++) if (highest.Length < num_array[i].Length) highest = num_array[i];
        return highest;
    }
}