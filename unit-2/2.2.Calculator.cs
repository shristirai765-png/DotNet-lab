// WAP in C# to make a simple calculator
using System;
using System.IO.Pipelines;

class Calculator
{
    public static void invoke()
    {
        Console.WriteLine("Enter value of x: ");
        int x = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter value of y: ");
        int y = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter value of z: ");
        int z = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Sum:"+ sum(x,y,z));
        Console.WriteLine("Product:"+ product(x,y,x));
        Console.WriteLine("Average:"+ average(x,y,z));
        // Console.WriteLine(subtract(2,4));
        // Console.WriteLine(multiply(44,3));
        // Console.WriteLine(divide(2,3));
    }
    static int sum(int x, int y, int z)
    {
        int result = x + y + z;
        return result;

    }
    // static int subtract(int x, int y)
    // {
    //     if(x > y)
    //     {
    //         return x-y;
    //     }
    //     else
    //         return y-x;

    // }
    static int product(int x, int y, int z)
    {
            return x * y * z;

    }
    // static double divide(double x, double y)
    // {
    //         return x/y;

    // }
    static double average(int x, int y, int z)
    {
        return (x + y+ z)/3;
    }
}