using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    public class ConvertValues
    {
        public static void KilometerToMeter()
        {
            Console.WriteLine("Enter Kilometer Value");
            double kmvalue=double.Parse(Console.ReadLine());
            Console.WriteLine(kmvalue + "km=" + (kmvalue * 1000) + "m");
        }
    }
}
