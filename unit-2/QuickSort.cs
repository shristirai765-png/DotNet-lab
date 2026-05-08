class QuickSort
{
    /*
    quick sort -> divide and conquer
    sorts an array by picking a "pivot" element and partitioning the other elements into two sub arrays
    based on whether they are less than or greater than pivot.
     */
    static int partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // choose last element as pivot
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;

                // swap arr[i] and arr[j]
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }

        // place pivot in correct position
        int temp1 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp1;

        return i + 1;
    }

    static void sorting(int[] arr, int lowest, int highest)
    {
        if (lowest < highest)
        {
            int pivot_index = partition(arr, lowest, highest);

            sorting(arr, lowest, pivot_index - 1);
            sorting(arr, pivot_index + 1, highest);
        }
    }

    public static void invoke()
    {
        int[] arr = { 7, 2, 9, 1, 5 };

        sorting(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted Array:");

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}