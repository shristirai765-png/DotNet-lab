class LargestAndSmallestNumber
{
    static int largest(int x, int y, int z)
    {
        if(x > y && x > z)
        {
            return x;
        }
        else if(y>x && y > z)
        {
            return y;
        }
        else
            return z;
    }
    static int smallest(int x, int y, int z)
    {
        if(x < y && x < z)
        {
            return x;
        }
        else if(y < x && y < z)
        {
            return y;
        }
        else
            return z;
    }
    public static void invoke()
    {
        Console.WriteLine("Enter value of x: ");
        int x = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter value of y: ");
        int y = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Enter value of z: ");
        int z = int.Parse(Console.ReadLine()!);
        int largeNum = largest(x,y,z);
        Console.WriteLine("The largest number among three numbers is: "+ largeNum);
        int smallNum = smallest(x,y,z);
        Console.WriteLine("The smallest number among three numbers is: "+ smallNum);
        
    }
}