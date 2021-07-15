using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgorithmProblems
{
    public class MergeSort<T> where T : IComparable
    {
        List<T> strArr;
        public MergeSort(List<T> ls)
        {
            this.strArr = ls;
        }
        public MergeSort()
        {
            Console.WriteLine("Merge Sort");
        }

        public void MergeSortArray()
        {
            
            int len = strArr.Count;
            MergeSort<T> ms = new MergeSort<T>();
            ms.Sort(strArr, 0, len - 1);
            Print(strArr);
        }

        public void Sort(List<T> arr,int l, int r)
        {
            if (l < r)
            {
                
                int m = l + (r - l) / 2;

               
                Sort(arr, l, m);
                Sort(arr, m + 1, r);


                MergeArray(arr, l, m, r);
            }
        }

        public void MergeArray(List<T> arr,int l,int m,int r)
        {
            
                
                int size1 = m - l + 1;
                int size2 = r - m;

                //string[] L = new string[size1];
                List<T> L = new List<T>(size1);
                //string[] R = new string[size2];
                List<T> R = new List<T>(size1);
                int i, j;

                for (i = 0; i < size1; i++)
                    L.Add(arr[l + i]);
                for (j = 0; j < size2; j++)
                    R.Add(arr[m + 1 + j]);

                
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

        private void Print(List<T> arr)
        {
            Console.WriteLine("---------After Sorting-------");
            foreach(T i in arr)
            {
                Console.Write($"{i} ");
            }
        }



    }
}
