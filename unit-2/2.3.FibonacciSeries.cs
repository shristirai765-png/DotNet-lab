/*WAP in C# to generate Fibonnaci series up to n terms*/
using System;

class FibonnaciSeries
{
    public static void invoke()
    {
        Console.WriteLine("Enter n input: ");
        int n =int.Parse(Console.ReadLine()!);

        for(int i = 0; i <= n-1; i++){
            Console.Write(Fibonacci(i));
            Console.Write("\t");
        }
        
    }
    static int Fibonacci(int n)
    {
        if(n == 1)
        {
            return 1;
        }
        else if(n == 0)
        {
            return 0;
        }
        else 
            return Fibonacci(n-1)+ Fibonacci(n-2);
    }
}