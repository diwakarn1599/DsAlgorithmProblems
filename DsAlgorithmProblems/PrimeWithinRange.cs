using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgorithmProblems
{
    class PrimeWithinRange
    {

        public static List<int> FindPrime()
        {
            List<int> primeList = new List<int>();
            Console.WriteLine("Enter the start range:");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the end range:");
            int end = Convert.ToInt32(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                else if (i == 2)
                {
                    primeList.Add(i);
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
                        primeList.Add(i);
                    }
                }
            }
            return primeList;
            
        }

        public static void Print(List<int> list)
        {
            foreach (int i in list)
            {
                Console.Write($" {i} ");
            }
        }
    }
}
