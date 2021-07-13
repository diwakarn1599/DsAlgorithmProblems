using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;



namespace DsAlgorithmProblems
{
    class Anagram
    {
        public static void StringAnagram()
        {
            string str1 = "dcba";
            string str2 = "cdab";
            FindAnagram(str1, str2);
        }

        private static void FindAnagram(string str1,string str2)
        {
            char[] str1Arr = str1.ToCharArray();
            char[] str2Arr = str2.ToCharArray();

            Array.Sort(str1Arr);
            Array.Sort(str2Arr);
            String s1 = new String(str1Arr);
            String s2 = new String(str2Arr);
            if (s1.Equals(s2))
            {
                Console.WriteLine($"{s1} and {s2} are anagrams");
            }
            else
            {
                Console.WriteLine($"{s1} and {s2} are not anagrams");
            }
        }
    }
}
