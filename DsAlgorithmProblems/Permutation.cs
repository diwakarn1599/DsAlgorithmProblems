using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DsAlgorithmProblems
{
    class Permutation
    {

        public static void ComputePermutation()
        {
            Permutation pm = new Permutation();
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            int start = 0, end = str.Length - 1;
            Console.WriteLine("Using Recursion");
            pm.PerumuteUsingRecursion(str,start,end);
            pm.PermuteUsingLoop(str, start, end);
        }

        private void PerumuteUsingRecursion(string str, int start,int end)
        {
            if(start == end)
            {
                Console.Write($" {str} ,");
            }
            else
            {
                for(int i = start; i <= end; i++)
                {
                    str = Swap(str, start, i);
                    PerumuteUsingRecursion(str, start + 1, end);
                    str = Swap(str, start, i);
                }
            }
        }
        
        private void PermuteUsingLoop(string s, int start, int end)
        {
            Console.WriteLine("\nUsing Iterations");
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string str = String.Join("", charArray);
            int i,j;
            while (true)
            {
                Console.Write($" {str} ,");
                i = end;
                while (str[i - 1] >= str[i])
                {
                    if (--i == 0)
                    {
                        return;
                    }
                        
                }
                j = end;
                while (j > i && str[j] <= str[i - 1])
                {
                    j--;
                }
                    
                str = Swap(str,i - 1, j);
                str = ReverseString(str, i);

            }

        }

        
        public static string Swap(string str, int start, int end)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;
            string s = new string(charArray);
            return s;
        }

        public static string ReverseString(string str, int k)
        {

            char[] charArray = str.ToCharArray();
            int j = str.Length - 1;
            for (int i = k; i < j; i++)
            {
                char temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
                j--;
            }
            return new string(charArray);



        }
    }
}
