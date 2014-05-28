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
                string[] input = reader.ReadLine().Split(' ');
                string numbers = input[0];
                string pattern = input[1];
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (pattern[i] == '-' || pattern[i] == '+')
                    {
                        string sub1 = "";
                        string sub2 = "";
                        sub1 = numbers.Substring(0, i);
                        sub2 = numbers.Substring(i, numbers.Length - i);
                        int num1 = Int32.Parse(sub1);
                        int num2 = Int32.Parse(sub2);
                        if (pattern[i] == '-')
                            Console.WriteLine("{0}", num1 - num2);
                        else
                            Console.WriteLine("{0}", num1 + num2);
                    }
                }
                Console.WriteLine();
            }
    }
}