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
                string[] line = reader.ReadLine().Split(',');
                int x = Int32.Parse(line[0]);
                int n = Int32.Parse(line[1]);
                int multiple = n;
                if (n >= x)
                    Console.WriteLine(n);
                else
                    while (multiple < x)
                    {
                        multiple = multiple + n;
                    }
                Console.WriteLine(multiple);
            }
    }
}