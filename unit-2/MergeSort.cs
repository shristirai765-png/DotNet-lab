/*
Merge Sort is divide and conquer algorithm that works recursively splitting an array into two halves, sorting each 
half, and then merging them back together in order.
*/
class MergeSort
{
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] L = new int[n1];
        int[] R = new int[n2];

        // copy data to temporary arrays
        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];

        for (int j = 0; j < n2; j++)
            R[j] = arr[mid + 1 + j];

        int a = 0, b = 0;
        int k = left;

        // merge the temp arrays
        while (a < n1 && b < n2)
        {
            if (L[a] <= R[b])
            {
                arr[k] = L[a];
                a++;
            }
            else
            {
                arr[k] = R[b];
                b++;
            }

            k++;
        }

        // copy remaining elements of L[]
        while (a < n1)
        {
            arr[k] = L[a];
            a++;
            k++;
        }

        // copy remaining elements of R[]
        while (b < n2)
        {
            arr[k] = R[b];
            b++;
            k++;
        }
    }

    static void Sort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            // sort first half
            Sort(arr, left, mid);

            // sort second half
            Sort(arr, mid + 1, right);

            // merge both halves
            Merge(arr, left, mid, right);
        }
    }

    public static void invoke()
    {
        int[] arr = { 38, 27, 43, 3, 9, 82, 10 };

        Sort(arr, 0, arr.Length - 1);

        Console.WriteLine("Sorted Array:");

        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}