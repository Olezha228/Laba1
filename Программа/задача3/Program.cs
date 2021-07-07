using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задача3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1000, b = 0.0001;
            double c, d, e, f, g, res;
            c = Math.Pow(a + b, 3);
            d = Math.Pow(a, 3);
            e = 3 * a * a * b;
            f = 3 * a * b * b;
            g = Math.Pow(b, 3);
            res = (c - (d + e)) / (f + g);
            Console.WriteLine("тип double даст результат = {0}", res);

            float af = 1000, bf = 0.0001f;
            float cf, df, ef, ff, gf, resf;
            cf = (float)Math.Pow(af + bf, 3);
            df = (float)Math.Pow(af, 3);
            ef = (float)3 * af * af * bf;
            ff = (float)3 * af * bf * bf;
            gf = (float)Math.Pow(bf, 3);
            resf = (float)(cf - (df + ef)) / (ff + gf);
            Console.WriteLine("тип float даст результат = {0}", resf);

        }
    }
}
