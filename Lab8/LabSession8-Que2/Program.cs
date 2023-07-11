using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSession8Que2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a C# program that can find the minimum and maximum from a given Single Dimenional Array.
            int[] _arr = { 2, 3, 4, 5, 6, 7 , 8};

            int min = _arr[0];
            int max = 0;
            for (int i = 0; i < _arr.Length; i++)
            {
                if (min > _arr[i])
                {
                    min = _arr[i];
                }

                if (max < _arr[i])
                {
                    max = _arr[i];
                }
            }

            Console.WriteLine($"Max: {max}\nMin: {min}");
        }
    }
}