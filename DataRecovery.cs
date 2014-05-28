using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        foreach (string line in File.ReadAllLines(args[0]))
        {
            string[] input = line.Split(';');
            string[] words = input[0].Split(' ');
            string[] nums = input[1].Split(' ');
            int numLen = nums.Length;
            int wordLen = words.Length;
            string sentence = "";
            bool found = false;
            for (int i = 1; i <= wordLen; i++)
            {
                found = false;
                for (int j = 0; j < numLen; j++)
                {
                    if (Int32.Parse(nums[j]) == i)
                    {
                        sentence += words[j] + " ";
                        found = true;
                    }
                }
                if (!found)
                    sentence += words[wordLen - 1] + " ";
            }
            Console.WriteLine(sentence);
        }
        
    }
}