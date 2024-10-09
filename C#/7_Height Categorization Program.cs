using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Height_Categorization_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your height in centimeters: ");
            int height = Convert.ToInt32(Console.ReadLine());

            if (height < 150)
            {
                Console.WriteLine("You are categorized as short.");
            }
            else if (height >= 150 && height <= 180)
            {
                Console.WriteLine("You are categorized as average height.");
            }
            else
            {
                Console.WriteLine("You are categorized as tall.");
               
            }
            Console.Read();
        }

    }
}