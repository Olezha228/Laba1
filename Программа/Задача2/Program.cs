using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=0, y=0;
            bool ok, oblast;
            string buf;

            do
            {
                Console.WriteLine("Введите координату х:");
                buf = Console.ReadLine();
                ok = double.TryParse(buf, out x);
                if (ok == false) Console.WriteLine("Ошибочное число, введите заново");
            }
            while (ok == false);

            do
            {
                Console.WriteLine("Введите координату y:");
                buf = Console.ReadLine();
                ok = double.TryParse(buf, out x);
                if (ok == false) Console.WriteLine("Введено ошибочное число, введите заново");
            }
            while (ok == false);

            oblast = (x<=0) && (y<=0) && (y >= (-1/7)*x -1);
            Console.WriteLine($"(x={x}, y={y}, x<=0) && (y<=0) && (y >= (-1/7)*x -1 = {oblast})"); ;
        }
    }
}
