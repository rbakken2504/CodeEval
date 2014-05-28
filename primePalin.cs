using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 999; i > 0; i--)
        {
            if (IsPrime(i) && IsPalin(i))
            {
                Console.Write(i);
                break;
            }
        }
        
    }
    static bool IsPrime(int n)
    {
        bool isPrime = false;
        if (n % 2 == 0)
            return false;
        else
        {
            for (int j = 32; j > 1; j--)
            {
                if (n % j == 0)
                {
                    isPrime = false;
                    break;
                }
                else
                    isPrime = true;
            }
            return isPrime;
        }
    }
    static bool IsPalin(int n)
    {
        int lastDigit = n % 10;
        int firstDigit = n / 100;
        int rev = lastDigit * 100 + firstDigit;
        n = (n / 100) * 100 + lastDigit;
        if (n == rev)
            return true;
        else
            return false;
    }
}