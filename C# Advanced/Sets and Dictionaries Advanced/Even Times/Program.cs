﻿using System;
using System.Collections.Generic;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,int> numbers = new Dictionary<int,int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int number =int.Parse(Console.ReadLine());
                if (!numbers.ContainsKey(number))
                {
                    numbers[number]=1;
                }
                else
                {
                    numbers[number]++;
                }
                
            }
            foreach (var number in numbers)
            {
                if (number.Value % 2 == 0)
                {
                    Console.WriteLine(number.Key);
                }
            }
        }
    }
}
