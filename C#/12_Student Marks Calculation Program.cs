using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Student_Marks_Calculation_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rollNo;
            string name;
            float[] marks = new float[3];
            float total, percentage;

           
            Console.Write("Enter Roll Number: ");
            rollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

           
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter marks for subject {i + 1}: ");
                marks[i] = Convert.ToSingle(Console.ReadLine());
            }

           
            total = marks[0] + marks[1] + marks[2];
            percentage = (total / 300) * 100;

            
            string division;
            if (percentage >= 60)
            {
                division = "First Division";
            }
            else if (percentage >= 50)
            {
                division = "Second Division";
            }
            else if (percentage >= 40)
            {
                division = "Third Division";
            }
            else
            {
                division = "Fail";
            }

            
            Console.WriteLine($"\nRoll Number: {rollNo}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Percentage: {percentage:F2}%");
            Console.WriteLine($"Division: {division}");

            Console.ReadLine();
        }
    }
}