using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DsAlgorithmProblems
{
    class BinarySearch
    {
        public static void BinarySearchfile()
        {
            string filePath = File.ReadAllText(@"C:\Users\NARD'S IDEAPAD\source\repos\DsAlgorithmProblems\DsAlgorithmProblems\words.txt");
            List<string> list = new List<string>(filePath.Split(" "));
            list.Sort();
            int mid, start = 0,end=list.Count-1;
            int flag = 0;
            Console.WriteLine("Enter the word to be searched in file");
            string word = Console.ReadLine();

            while (start <= end)
            {
                mid = (start + end) / 2;
                int result = word.CompareTo(list[mid]);
                if (result == 0)
                {
                    Console.WriteLine($"{word} is Present in file");
                    flag = 1;
                    break;
                }
                else if (result > 0)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            if (flag==0)
            {
                Console.WriteLine("Word not found!");
            }
        }
    }
}
