//WAP in C# to demonstrate the difference between pass by value and pass by reference using ref and out keyword

class PassByValueVsReference
{
    static void valuePass(int x)
    {
        int square = x * x;
        Console.WriteLine(square);
    } 
    static void refPass(ref int x, ref int y)
    {
        x += 10 ;
        y += 10 ;
    }
    static void refPassUsingOut(out int x, out int y)
    {
        x = 100;
        y = 200;
    }
    public static void invoke()
    {
        int one = 1;
        int two = 2;
        int once;
        int twice;
        valuePass(6);
        Console.WriteLine(one);
        Console.WriteLine(two);
        refPass(ref one, ref two);
        Console.WriteLine(one);
        Console.WriteLine(two);
        refPassUsingOut(out once, out twice);
        Console.WriteLine(once);
        Console.WriteLine(twice);
    }
}