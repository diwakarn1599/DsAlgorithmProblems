using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgorithmProblems
{
    class PrimeWithinRange
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the start range:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end range:");
            int end = Convert.ToInt32(Console.ReadLine());
            FindPrime(start, end);
        }

        public static void FindPrime(int start, int end)
        {
            Console.Write("[");
            for (int i = start; i <= end; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                else if (i == 2)
                {
                    Console.Write($" {i}");
                }
                else if(i%2 != 0)
                {
                    int f = 0;
                    for (int j = 3; j * j <=i ; j++)
                    {
                        if (i % j == 0)
                        {
                            f = 1;
                            break;
                        }
                    }
                    if (f != 1)
                    {
                        Console.Write($" {i}");
                    }
                }
            }
            Console.Write(" ]");
        }
    }
}
