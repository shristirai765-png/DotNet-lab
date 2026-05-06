using System.Data;

class ExpressionBodied
{
    static int square(int x)=> x*x;
    static int area (int x) => x * x;

    static int cube (int x) => x * x * x;

    static int cube (int x, int y, int z) => x * y * z;

    public static void invoke()
    {
        Console.WriteLine(square(5));
        Console.WriteLine(area(5));
        Console.WriteLine(cube(5));
        Console.WriteLine(cube(1,2,3));
    }
}