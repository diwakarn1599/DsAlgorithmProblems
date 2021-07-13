using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgorithmProblems
{
    class InsertionSort
    {
        public static void InsertionSortString()
        {
            string[] strArr = { "in", "I", "Diwakar", "Tvs Next", "working", "am" };
            int len = strArr.Length;
            Console.WriteLine("Array of string ---> Before Sorting:\n");
            foreach (string i in strArr)
            {
                Console.Write($"{i} ");
            }
            sort(strArr, len);
        }

        //Insertion sort 
        public static void sort(string[] strArr,int len)
        {
            for (int i = 1; i < len; i++)
            {
                String temp = strArr[i];
                int j = i - 1;
                while (j >= 0 && temp.Length < strArr[j].Length)
                {
                    strArr[j + 1] = strArr[j];
                    j--;
                }
                strArr[j + 1] = temp;
            }
            Console.WriteLine("\nArray of string ---> After Sorting:\n");
            foreach (string i in strArr)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
