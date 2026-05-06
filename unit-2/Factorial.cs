class Factorial
{
    static int factorialNumber(int n)
    {
        if(n <= 1)
        {
            return 1;
        }
        else 
            return n * factorialNumber(n-1);
    }

    public static void invoke()
    {
        Console.WriteLine("Enter any integer value:");
        int value = int.Parse(Console.ReadLine()!);
        int result = factorialNumber(value);
        Console.WriteLine("The result is: "+ result);
    }

}