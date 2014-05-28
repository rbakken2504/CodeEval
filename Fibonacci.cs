using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    //2nd revision, forgot to take out debugging print statement in first revision
    //Also, used ulongs in case of Fibonacci's over limit of uint, due to lack
    //of constraints in problem description--was unnecessary though.
    static void Main(string[] args)
    {
        foreach (string line in File.ReadAllLines(args[0]))
        {
            uint input = UInt32.Parse(line);
            Console.WriteLine(Fibonacci(input));
        }
        
    }
    static int Fibonacci(uint n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}