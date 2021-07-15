using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgorithmProblems
{
    class BubbleSort<T> where T:IComparable
    {
        public static void BubbleSortArray(List<T> arr)
        {
            
            int len = arr.Count;
            sort(arr, len);
        }

        public static void sort(List<T> arr, int len)
        {
            Console.WriteLine("Before Sorting:\n");
            Print(arr);
            T temp;
            for(int i = 0; i < len - 1; i++)
            {
                for(int j = 0; j < len - i - 1; j++)
                {
                    
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
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

        public static void  Print(List<T> arr)
        {
            Console.Write("[");
            foreach(T i in arr)
            {
                Console.Write($"{i} ");
            }
            Console.Write("]");
        }
    }
}
