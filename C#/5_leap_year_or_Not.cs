﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_leap_year_or_Not
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());


            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
            Console.Read();
        }
    }
}