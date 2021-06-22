using System;

namespace A1SumMultiof3and5to100
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int sum = 0;

            for (int i = 0;  i <= 100; i++)
            {
                num1 = i % 3;
                num2 = i % 5;

                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write("{0}\t", i);
                    sum = sum + i;

                }
            }
            Console.WriteLine();
            Console.WriteLine("\nThe sum of multiples of 3 and 5 from 1 to 100 is: {0}", sum);
            Console.ReadLine();
        }
    }
}
