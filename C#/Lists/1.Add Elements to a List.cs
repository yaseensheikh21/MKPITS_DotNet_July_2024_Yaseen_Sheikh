using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Add_Elements_to_a_List
{
    internal class Program
    {
        static void AddElementsToList(List<int> numbers, List<int> elementsToAdd)
        {
            numbers.AddRange(elementsToAdd);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void Main(string[] args)
        {
            List<int> myNumbers = new List<int> { 10, 20, 30 };
            List<int> elementsToAdd = new List<int> { 1, 2, 3, 4, 5 };

            AddElementsToList(myNumbers, elementsToAdd);
            Console.Read();
        }
        
    }
}