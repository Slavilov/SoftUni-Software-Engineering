﻿using System;
using System.Text;

namespace HelloSoftUni
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number = number / 10;
            }
            Console.WriteLine(sum);

        }
    }
}