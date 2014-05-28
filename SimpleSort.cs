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
                string[] line = reader.ReadLine().Split(' ');
                List<double> unsorted = new List<double>();
                foreach (string num in line)
                {
                    unsorted.Add(Double.Parse(num));
                }
                unsorted.Sort();
                foreach (double num in unsorted)
                    Console.Write(String.Format("{0:F3} ", num));
                Console.WriteLine();                    
            }
    }
}