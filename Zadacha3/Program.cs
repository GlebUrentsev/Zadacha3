using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ok;
            double x, y;
            double result;
            while (true)
            {
                do
                {
                    Console.WriteLine("Введите координату X");
                    ok = double.TryParse(Console.ReadLine(), out x);
                    if (!ok) Console.WriteLine("Ошибка, неверное значение координаты");
                } while (!ok);

                do
                {
                    Console.WriteLine("Введите координату Y");
                    ok = double.TryParse(Console.ReadLine(), out y);
                    if (!ok) Console.WriteLine("Ошибка, неверное значение координаты");
                } while (!ok);

                if (y >= 0 && y <= 1 && y >= Math.Pow(x, 2) && y <= Math.Pow(Math.E, -x) || y >= 0 && y <= 1 && y >= Math.Pow(x, 2) && y >= Math.Pow(Math.E, x))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Точка принадлежит плоскости, тогда U = x+y");
                    result = x + y;
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Точка не принадлежит плоскости, тогда U = x-y");
                    Console.ResetColor();
                    result = x - y;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"U = {result}");
                Console.ResetColor();
            }
        }
    }
}
