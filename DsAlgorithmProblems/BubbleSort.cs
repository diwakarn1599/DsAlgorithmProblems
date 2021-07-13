using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgorithmProblems
{
    class BubbleSort
    {
        public static void BubbleSortArray()
        {
            int[] arr = { 5, 13, 15, 2, 27, 7 };
            int len = arr.Length;
            sort(arr, len);
        }

        public static void sort(int[] arr, int len)
        {
            Console.WriteLine("Before Sorting:\n");
            Print(arr);
            int temp;
            for(int i = 0; i < len - 1; i++)
            {
                for(int j = 0; j < len - i - 1; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nAfter Sorting:\n");
            Print(arr);
        }

        public static void  Print(int[] arr)
        {
            Console.Write("[");
            foreach(int i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.Write("]");
        }
    }
}
