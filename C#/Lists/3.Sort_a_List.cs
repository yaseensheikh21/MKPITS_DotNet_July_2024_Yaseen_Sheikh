using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_a_List
{
    internal class Program
    {
        static void SortList(List<int> numbers)
        {
            numbers.Sort();
            Console.WriteLine("Ascending Order:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Reverse();
            Console.WriteLine("\nDescending Order:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void Main(string[] args)
        {
            List<int> myNumbers = new List<int>(); 

            Console.WriteLine("Enter integers separated by spaces:");
            string input = Console.ReadLine();  
            string[] inputs = input.Split(' ');

            foreach (string str in inputs)
            {
                int number;
                if (int.TryParse(str, out number))  
                {
                    myNumbers.Add(number); 
                }
                else
                {
                    Console.WriteLine($"'{str}' is not a valid integer. Skipping.");
                }
            }

            if (myNumbers.Count > 0)
            {
                SortList(myNumbers); 
            }
            else
            {
                Console.WriteLine("No valid integers were entered.");
            }

            Console.Read();
        }
    }
}