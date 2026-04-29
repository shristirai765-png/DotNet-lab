class IterationStatement
{
    static void infiniteWhileLoop(int x)
    {
        while (x<6)
        {
            Console.WriteLine("Hello!");
            x--;
        }
    }
    static void jumpStatement()
    {
        startloop;
        Console.WriteLine("Hello");
        goto startloop;
    }
    public static void invoke()
    {
        infiniteWhileLoop(6);
        jumpStatement();
    }
}