using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Задание_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double S, R, r;
            Console.Write("Введите внутренний радиуc кольца = 20: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите внешний радиуc кольца >= 20: ");
            R = Convert.ToDouble(Console.ReadLine());
            {
                S = (Math.PI * (R * R - r * r));
                Console.Write("Площадь кольца ={0}", S);
            }
            Console.ReadKey();

        }
    }
}
