class BubbleSort
{
    static int[] sorting(int[] arr)
    {
        int temp;
        for(int i = 0; i<arr.Length; i++)
        {
            for(int j = 0; j < arr.Length-1; j++)
            {
                if (arr[j] > arr[j + 1])
            {
                temp = arr[j];
                arr[j]= arr[j+1];
                arr[j+1]= temp;
    
            }
           
            }
            
        }
        return arr;
    }
    public static void invoke()
    {
        int[] unsortedArray = {14, 4, 5, 0, 24};
        int[] result = sorting(unsortedArray);
        Console.WriteLine("The sorted array is: ");
        foreach(int r in result)
        {
            Console.Write(" "+ r );
        }
    }
}