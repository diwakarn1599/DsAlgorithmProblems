using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgorithmProblems
{
    class MergeSort
    {
        string[] strArr = { "in", "I", "Diwakar", "Tvs Next", "working", "am" };
        public void MergeSortArray()
        {
            
            int len = strArr.Length;
            MergeSort ms = new MergeSort();
            ms.Sort(strArr, 0, len - 1);
            Print(strArr);
        }

        private void Sort(string[] arr,int l, int r)
        {
            if (l < r)
            {
                
                int m = l + (r - l) / 2;

               
                Sort(arr, l, m);
                Sort(arr, m + 1, r);


                MergeArray(arr, l, m, r);
            }
        }

        private void MergeArray(string[] arr,int l,int m,int r)
        {
            
                
                int size1 = m - l + 1;
                int size2 = r - m;

                string[] L = new string[size1];
                string[] R = new string[size2];
                int i, j;

               for (i = 0; i < size1; ++i)
                    L[i] = arr[l + i];
                for (j = 0; j < size2; ++j)
                    R[j] = arr[m + 1 + j];

                
                i = 0;
                j = 0;

                int k = l;
                while (i < size1 && j < size2)
                {
                int res = L[i].CompareTo(R[j]);
                    if (res<=0)
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;
                    }
                    k++;
                }

                while (i < size1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }
                while (j < size2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            

        }

        private void Print(string[] arr)
        {
            foreach(string i in arr)
            {
                Console.Write($"{i} ");
            }
        }



    }
}
