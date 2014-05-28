using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int i = 2;
        int count = 0;
        int sumPrimes = 0;
        do
        {
            if (IsPrime(i))
            {
                sumPrimes += i;
                count++;
            }
            i++;
        }
        while (count < 1000);
        Console.Write(sumPrimes);
    }
    static bool IsPrime(int n)
    {
        //bool isPrime = false;
        //if (n % 2 == 0)
        //    return isPrime;
        //else
        //{
        //    int root = (int) Math.Ceiling(Math.Sqrt(n));
        //    for (int j = root; j > 1 ; j--)
        //    {
        //        if (n % j == 0)
        //        {
        //            isPrime = false;
        //            break;
        //        }
        //        else
        //            isPrime = true;
        //    }
        //    return isPrime;
        //}
        bool isPrime = true;
        for (int j = 2; j <= n / 2; j++)
        {
            if (n % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
}