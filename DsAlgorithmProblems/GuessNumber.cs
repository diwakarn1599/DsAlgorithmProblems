using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgorithmProblems
{
    class GuessNumber
    {
        int first = 0, last = 100;
        bool found = false;
        public  void GuessANumber()
        {
            Console.WriteLine($"Think a number between {this.first} - {this.last} ");
            while (first != last && found == false)
            {
                int mid = (first + last) / 2;
                CheckValue(mid);
            }
            if (first == last)
            {
                Console.WriteLine($"Your number is {this.first}");
            }
            
        }

        public void CheckValue(int mid)
        {
            Console.WriteLine($"PRESS\n1.If your number is {mid}\n2.If your number is less than {mid}\n3.If your number is greater than {mid}");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine($"Your number is {mid}");
                    found = true;
                    break;
                case 2:
                    this.last = mid - 1;
                    break;
                case 3:
                    this.first = mid + 1;
                    break;
            }
        }
    }
}
