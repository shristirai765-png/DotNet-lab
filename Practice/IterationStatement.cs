class IterationStatement
{
    static void infiniteWhileLoop()
    {
        while (true)
        {
            Console.WriteLine("Hello!");
        }
    }
    public static void invoke()
    {
        infiniteWhileLoop();
    }
}