﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Showing_EVEN_or_ODD_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            Console.Read();
        }
    }
}