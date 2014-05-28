using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        byte[] size = File.ReadAllBytes(args[0]);
        Console.WriteLine(size.Length);
    }
}