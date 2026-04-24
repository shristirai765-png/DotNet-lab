/* 
Wap in C# to demonstrate the difference between params and optional parameters,
 using sum for params and multiply by 0 for optional parameters.
*/

class ParameterVsOptionalParameter
{
    static int Sum(params int[] ints)
    {
        int sum = 0;
        for(int i = 0; i<ints.Length; i++)
        {
            sum += ints[i];

        }
        return sum;
    }
    static void DisplayGreeting(string name, string message = "Hello") 
    {
        Console.WriteLine($"{message}, {name}!");
    }

    public static void invoke()
    {
        int result = Sum(1,2,3,4);
        Console.WriteLine(result);
        DisplayGreeting("Shristi");
    }
}