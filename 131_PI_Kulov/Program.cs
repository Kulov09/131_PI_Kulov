using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131_PI_Kulov
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Размер дневной выручки равен");
            a = Convert.ToInt32(Console.ReadLine());
            if (a <= 1000)
            {
                b = a / 100 * 5;
                Console.WriteLine("Размер выручки равен");
                Console.Write(b);
            }

            if (a > 10000)
            {
                b = a / 100 * 10 + 500;
                Console.WriteLine("Размер выручки равен");
                Console.WriteLine(b);
            }
            Console.ReadKey();

                

             
        }
    }
}
