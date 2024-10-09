using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Remove_Elements_from_a_List
{
    internal class Program
    {
        static void RemoveElementFromList(List<string> items, string elementToRemove)
        {
            items.Remove(elementToRemove);

            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            List<string> myItems = new List<string> { "apple", "banana", "orange", "grape" };
            string elementToRemove = "grape";

            RemoveElementFromList(myItems, elementToRemove);
            Console.ReadLine();
        }
    }
}
