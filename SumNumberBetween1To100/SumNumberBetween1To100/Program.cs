using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumNumberBetween1To100
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 100;
            int i = 1;
            do
            {
                if ((i % 2 == 0))
                    sum += i;
                i++;
            } while (i <= num);

            Console.WriteLine("Sum of even numbers from 1 to {0} is : {1}",num,sum);
            Console.ReadLine();
        }
    }
}
