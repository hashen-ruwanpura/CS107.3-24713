using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession8Que3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a C# program that can sort a Single Dimentional Array according to ascending and descending order.
            int[] _arr = { 1, 2, 38, 67, 5, 78, 17, 12, 24, 34 };

            Console.WriteLine("Original Array:");
            PrintArray(_arr);

            Console.WriteLine("\nArray Sorted in Ascending Order:");
            Array.Sort(_arr);
            int[] ascendingArray = _arr;
            PrintArray(ascendingArray);

            Console.WriteLine("\nArray Sorted in Descending Order:");
            Array.Sort(_arr);
            Array.Reverse(_arr);
            int[] descendingArray = _arr;
            PrintArray(descendingArray);

            void PrintArray(int[] array)
            {
                foreach (int num in array)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
