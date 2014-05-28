using System;
using System.IO;
using System.Collections.Generic;

 class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                int len = line.Length;
                int sum = 0;
                for (int i = 0; i < len; i++)
                {
                    sum = sum + Int32.Parse(line.Substring(i, 1));
                }
                Console.WriteLine(sum);
            }
    }
}