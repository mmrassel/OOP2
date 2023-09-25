using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[8];
            for(int i =0;i<8;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }


            int x = a[0], y = a[0];

            for(int i = 1; i<8; i++)
            {
                if (a[i] > x)
                {
                    x = a[i];
                }
                if (a[i] < y)
                {
                    y = a[i];   
                }
            }

            Console.WriteLine($"Max Value is: {x}"); ;
            Console.WriteLine($"Min Value is: {y}"); ;
            Console.ReadLine();            
        }
    }
}
