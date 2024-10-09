using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Sign__Detection__Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the value of m: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int n;


            if (m > 0)
            {
                n = 1;
            }
            else if (m == 0)
            {
                n = 0;
            }
            else
            {
                n = -1;
            }
            Console.WriteLine("The value of n is: " + n);
            Console.Read();
        }
    }
}