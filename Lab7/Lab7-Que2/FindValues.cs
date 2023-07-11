using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_Que2
{
    internal class FindValues
    {

    public double FindArea(double radius)
        {
            double area = 22/7 * radius * radius;
            return area;
        }

        public double FindCircumference(double radius)
        {
            double circumference = 2 * 22/7 * radius;
            return circumference;
        }
    }
}

