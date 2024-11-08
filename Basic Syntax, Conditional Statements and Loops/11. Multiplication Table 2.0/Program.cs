using System;

namespace Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int multitplier = int.Parse(Console.ReadLine());
            // int m = 1;


            //     if (n > multitplier && 10 >= multitplier)
            //     {
            //       for (int i = 1; i <= 10; i++)
            //       {
            //         Console.WriteLine($"{n} X {m} = {n * m}");
            //         m++;
            //       }
            //     }
            //     else if (multitplier > n && multitplier <=10)
            //     {
            //         for (int i = multitplier; i <= 10; i++)
            //         {
            //           Console.WriteLine($"{n} X {i} = {n * i}");
            //         }
            //     }
            //    else if (multitplier > 10)
            //    {
            //      Console.WriteLine($"{n} X {multitplier} = {n * multitplier}");
            //    }

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b >=10)
            {
                Console.WriteLine(value: $"{a} X {b} = {a * b}");
            }

            for (int i = 0; i <= 10-b; i++)
            {
                Console.WriteLine(value: $"{a} X {b+i} = {a * (b+i)}");
            }
        }
    }
}