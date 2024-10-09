using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Quadratic_Equation_Root_Calculator_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accept coefficients a, b, and c from the user
            Console.Write("Enter coefficient a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter coefficient c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Roots are real and different: {root1} and {root2}");
            }
            else if (discriminant == 0)
            {

                double root = -b / (2 * a);
                Console.WriteLine($"Roots are real and the same: {root}");
            }
            else
            {

                Console.WriteLine("Roots are complex and different.");
            }
            Console.Read();
        }
    }
}
