using System;

using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Addition_And_Substraction_Of_Two_Arrays
{
    internal class Addition_And_Substraction_Of_Two_Arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Array Size:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[,] Sum = new int[size,size];
            int[,] Array1 = new int[size,size];
            int[,] Array2 = new int[size, size];

            Console.WriteLine("Enter Array1 Elements:");               //this for loop is for taking inputs only
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {

                    Array1[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter Array2 Elements:");             //this for loop is for taking inputs only
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Array2[row, col] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Addition is:");
            for (int row = 0; (row < size); row++) 
            { 
                for(int col = 0;col < size; col++)
                {
                    Sum[row , col] = Array1[row,col] + Array2[row,col];
                    Console.Write(Sum[row,col]+"\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Substraction is: \n");
            for (int row = 0; (row < size); row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Sum[row, col] = Array1[row, col] - Array2[row, col];
                    Console.Write("["+Sum[row, col]+"]"+"\t");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
