using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the number " + (i + 1) + ": ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Average: " + (sum / 10.0f));

        }
    }  
}