using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Coordinate_Quadrant_Determination_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the x-coordinate: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the y-coordinate: ");
            double y = Convert.ToDouble(Console.ReadLine());


            if (x > 0 && y > 0)
            {
                Console.WriteLine("The point is in Quadrant I.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point is in Quadrant II.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point is in Quadrant III.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point is in Quadrant IV.");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("The point is on the Y-axis.");
            }
            else if (y == 0 && x != 0)
            {
                Console.WriteLine("The point is on the X-axis.");
            }
            else
            {
                Console.WriteLine("The point is at the origin.");
            }
            Console.ReadLine();
        }
    }
}
