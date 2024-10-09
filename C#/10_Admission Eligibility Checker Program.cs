using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Admission_Eligibility_Checker_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            float marks;

           
            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your marks (out of 100): ");
            marks = Convert.ToSingle(Console.ReadLine());

            if (age >= 18 && marks >= 50)
            {
                Console.WriteLine("You are eligible for admission to the professional course.");
            }
            else
            {
                Console.WriteLine("You are not eligible for admission to the professional course.");
            }
            Console.ReadLine();

        }
    }
}
