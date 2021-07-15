using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgorithmProblems
{
    class InsertionSort<T> where T: IComparable
    {
        public static void InsertionSortString(List<T> list)
        {
            List<T> strArr = list;
            int len = strArr.Count;
            Console.WriteLine("Array of string ---> Before Sorting:\n");
            foreach (T i in strArr)
            {
                Console.Write($"{i} ");
            }
            sort(strArr, len);
        }

        //Insertion sort 
        public static void sort(List<T> strArr,int len)
        {
            for (int i = 1; i < len; i++)
            {
                T temp = strArr[i];
                int j = i - 1;
                while (j >= 0 && strArr[j].CompareTo(temp) > 0)
                {
                    strArr[j + 1] = strArr[j];
                    j--;
                }
                strArr[j + 1] = temp;
            }
            Console.WriteLine("\nArray of string ---> After Sorting:\n");
            foreach (T i in strArr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
