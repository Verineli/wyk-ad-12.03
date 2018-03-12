using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RownaniaKwadratowe
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x1, x2;
            a = 1;
            b = 2;
            c = -10;
            x1 = 0;x2 = 0;
            double delta = b * b - 4 * a * c;
            if (a == 0)
            {
                    Console.WriteLine("cos");
            }
            else if (delta >= 0)
            {
                x1 = (-b - Math.Sqrt(delta)) / 2 * a;
                x2 = (-b + Math.Sqrt(delta)) / 2 * a;
            }
            else
            {
                Console.WriteLine("Brak rozwiązań rzeczywistych");
            }
            
            Console.WriteLine("Pierwiastki to: {0} i {1}", x1, x2);
        }
    }
}
