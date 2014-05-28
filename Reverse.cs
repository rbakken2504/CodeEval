using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
        while (!reader.EndOfStream)
        {
            string line = reader.ReadLine();
            if(line == null || line == "")
                continue;
            string[] input = line.Split(' ');                   
            for(int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write(input[i] + " ");
            }
            Console.WriteLine();
        }
    }
}