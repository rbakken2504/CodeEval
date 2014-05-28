using System.IO;
using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0])) 
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;
                string[] input = line.Split(' ');
                byte a = Byte.Parse(input[0]);
                byte b = Byte.Parse(input[1]);
                byte n = Byte.Parse(input[2]);

                for (int i = 1; i <= n; i++)
                {
                    if (i % b == 0 && i % a == 0)
                        Console.Write("FB ");
                    else if (i % b == 0)
                        Console.Write("B ");
                    else if (i % a == 0)
                        Console.Write("F ");
                    else
                        Console.Write(i + " ");
                    if (i == n)
                        Console.WriteLine();
                }
            }
    }
}
