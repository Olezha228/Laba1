using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача1

{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0, res1 = 0;
            bool ok, res2, res3;
            string buf;
            double x = 0 , res4 = 0;

            do
            {
                Console.WriteLine("Введите число целое m:");
                buf = Console.ReadLine();
                ok = int.TryParse(buf, out m);
                if (ok==false) Console.WriteLine("Введено ошибочное число, введите число заново");
            }
            while (ok == false );

            do
            {
                Console.WriteLine("Введите целое число n:");
                buf = Console.ReadLine();
                ok = int.TryParse(buf, out n);
                if (!ok) Console.WriteLine("Введено ошибочное число, введите заново");
            }
            while (!ok);

            if (n == 1) Console.WriteLine("Операция невозможна");
            else
            {
                res1 = m / (--n);
                n++;
                Console.WriteLine($"m={m}, n={n}, m / (--n++) = {res1}");
                res2 = m / n < n--;
                Console.WriteLine($"m={m}, n={n}, m / n < n-- = {res2}");
                res3 = m + n++ > n + m;
                Console.WriteLine($"m={m}, n={n}, m + n++ > n + m = {res3}"); 
            }

            do
            {
                Console.WriteLine("введите число х вещественного типа:");
                buf = Console.ReadLine();
                ok = double.TryParse(buf, out x);
                if (ok == false) Console.WriteLine("Введено ошибочное число, введите снова");
            }
            while (ok == false);

            res4 = (Math.Pow(x, 2) * Math.Sqrt(Math.Abs(x - 1))) + Math.Abs(25 - Math.Pow(x, 5));
            Console.WriteLine("Полученный результат = {0}", res4);


        }
    }
}
