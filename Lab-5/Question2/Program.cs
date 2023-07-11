using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Que2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 7, 8 };
            int[] b = { 6, 2, 4 };

            int scoreA = 0;
            int scoreB = 0;

            for(int i=0; i<a.Length; i++)
            {
                if (a[i] > b[i]) 
                {
                    scoreA++;
                }
                else if (a[i] < b[i])
                {
                    scoreB++;
                }
                Console.WriteLine("Anura's Score:" +scoreA);
                Console.WriteLine("Bhagys Score:" +scoreB);

            }
        }
    }
}
