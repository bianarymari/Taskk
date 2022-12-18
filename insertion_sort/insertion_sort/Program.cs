using System;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
            int n = 10, i, j, val, ff;
            Console.WriteLine("Insertion Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                ff = 0;
                for (j = i - 1; j >= 0 && ff != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else ff= 1;
                }
            }
            Console.Write("  Sorted Array is: ");
         for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
