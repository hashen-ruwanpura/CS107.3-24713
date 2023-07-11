using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Session_8
{
    internal class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter value " + (i + 1) + ": ");
            array[i] = int.Parse(Console.ReadLine());
        }

        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        int scalarSum = sum;

        sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i] * (i + 1);
        }
        int linearSum = sum;

        Console.WriteLine("Scalar Sum: " + scalarSum);
        Console.WriteLine("Linear Sum: " + linearSum);
    }
}
}
