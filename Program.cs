using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace формула_герона
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("введите 1 сторону треугольника: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите 2 сторону треугольника: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите 3 сторону треугольника: ");
            double c = Convert.ToDouble(Console.ReadLine());

            while (a > b + c || b > c + a || c > b + a)
            {
                Console.WriteLine("невозможный треугольник повторите ввод");
                Console.Write("введите 1 сторону треугольника: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("введите 2 сторону треугольника: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("введите 3 сторону треугольника: ");
                c = Convert.ToDouble(Console.ReadLine());
            }

            schetploshadi ploshd = new schetploshadi();
            Console.WriteLine();
            Console.WriteLine($"площадь треугольника равна {ploshd.treugolnic(a,b,c)}");
            Console.ReadKey();
        }
    }

    public class schetploshadi
    {
        public double treugolnic(double a, double b, double c)
        {
            double poluper = (a + b + c) / 2;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(poluper);
            return Math.Sqrt(poluper * (poluper - a) * (poluper - b) * (poluper - c));
        }
    }
}
