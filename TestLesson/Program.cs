
using System;

namespace TestLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Преобразование чисел";
            int x = 12;
            sbyte y = -127;

            Console.WriteLine($"Hello! {str} а");
            float num = (float)x / y; // предварительно преобразую делимое
            
            // второй вариант явного преобразования
            double num2 = Convert.ToDouble(x) / y;
            Console.WriteLine("Hello again float {0}, double {1} ", num, num2);
            double[] kft= { 0,0,0};
            Console.WriteLine("Введите последовательно 3 коэффициента a, b, c квадратного уравнения, нажимая Enter!");
            for ( byte i = 0; i<3; i++)
            {
                kft[i] = double.Parse(Console.ReadLine());
            }
            double a = kft[0];
            double b = kft[1];
            double c = kft[2];

            double D= Math.Pow(b,2)-4*a*c;
            Console.WriteLine($"Дискрименант {D}");
            double x1 = (-b - Math.Sqrt(D))/2*a;
            double x2 = (-b + Math.Sqrt(D)) / 2 * a;
            // распарсить 
            Console.WriteLine($"Корни уравнения {x1} и {x2}");

        }
    }
}
