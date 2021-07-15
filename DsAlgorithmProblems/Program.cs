using System;
using System.Collections.Generic;
using System.Text;
namespace DsAlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure algorithm Problems");
            Console.WriteLine("MENU");
            Console.WriteLine("1.Permutation\n2.Binary Search\n3.Insertion Sort\n4.Bubble Sort\n5.Merge Sort\n6.Anagram\n7.Prime Within Range\n8.Anagram and palindrome of prime numbers\n9.Guess Number\n10.Exit\nENTER AN OPTION");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Permutation.ComputePermutation();
                    break;
                case 2:
                    BinarySearch<string>.BinarySearchfile();
                    break;
                case 3:
                    List<string> InsertionSortList = new List<string> {"in", "I", "Diwakar", "Tvs Next", "working", "am" };
                    InsertionSort<string>.InsertionSortString(InsertionSortList);

                    break;
                case 4:
                    
                    List<int> BubbleSortList = new List<int> { 5, 13, 15, 2, 27, 7 };
                    BubbleSort<int>.BubbleSortArray(BubbleSortList);
                    break;
                case 5:
                    List<string> MergeSortList = new List<string> { "in", "I", "Diwakar", "Tvs Next", "working", "am" };
                    MergeSort<string> ms = new MergeSort<string>(MergeSortList);
                    ms.MergeSortArray();
                    break;
                case 6:
                    Anagram.StringAnagram();
                    break;
                case 7:
                    List<int> list= PrimeWithinRange.FindPrime();
                    PrimeWithinRange.Print(list);
                    break;
                case 8:
                    AnagramAndPalindromePrimeNum anagramAndPalindrome = new AnagramAndPalindromePrimeNum();
                    anagramAndPalindrome.CheckPrimeAnagramAndPalindrome();
                    break;
                case 9:
                    GuessNumber gn = new GuessNumber();
                    gn.GuessANumber();
                    break;
                case 10:
                    Console.WriteLine("Exited");
                    break;
            }
            

        }
    }
}
