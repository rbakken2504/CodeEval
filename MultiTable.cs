using System;
using System.IO;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 12; i++)
        {
            for(int j = 1; j <= 12; j++)
            {
                Console.Write(String.Format("{0, 4}", j * i));
            }
            Console.WriteLine();
        }
    }
}

