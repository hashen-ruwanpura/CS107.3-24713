using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Que2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the radius of the circle: ");
            double radius = double.Parse(Console.ReadLine());

            FindValues Objcalculator = new FindValues();

            double area = Objcalculator.FindArea(radius);
            Console.WriteLine("Area of the circle: " + area);

            double circumference = Objcalculator.FindCircumference(radius);
            Console.WriteLine("Circumference of the circle: " + circumference);

            Console.ReadLine();
        }
    }
}
