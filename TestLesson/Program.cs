
using System;

namespace TestLesson
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Урок1 /числа/
            /*
            string str = "Преобразование чисел";
            int x = 12;
            sbyte y = -127;

            Console.WriteLine($"Hello! {str} а");
            float num = (float)x / y; // предварительно преобразую делимое

            // второй вариант явного преобразования
            double num2 = Convert.ToDouble(x) / y;
            Console.WriteLine("Hello again float {0}, double {1} ", num, num2);
            //double[] kft= { 0,0,0};
            double[] kft = new double[3];
            Console.WriteLine("Введите последовательно 3 коэффициента a, b, c квадратного уравнения, нажимая Enter!");
            for (byte i = 0; i < 3; i++)
            {
                kft[i] = double.Parse(Console.ReadLine());
            }
            double a = kft[0];
            double b = kft[1];
            double c = kft[2];

            double D = Math.Pow(b, 2) - 4 * a * c;
            Console.WriteLine($"Дискрименант {D}");
            double x1 = (-b - Math.Sqrt(D)) / 2 * a;
            double x2 = (-b + Math.Sqrt(D)) / 2 * a;
            // распарсить 
            Console.WriteLine($"Корни уравнения {x1} и {x2}");
              */
            #endregion

            #region Урок 2 /строки/ 
            Console.OutputEncoding = System.Text.Encoding.UTF8; // для кириллицы если не отображается
            Console.WriteLine("Привет мир!");
            char chr = 'a'; // 2 байта
            string str1 = "строка";
            string str2 = "Еще одна Строка";
            Console.WriteLine($"Длина строки ={str1.Length} символа, что составляет {str1.Length * 2} байт");

            Console.WriteLine($"Читаю посимвольно как из массива {str1[0]} {str1[3]} + {str1[4]}"); // "сок"
            Console.WriteLine($"Читаю посимвольно из массива и складываю  {str1[0]+str1[3]+str1[4]}"); // число - сумма кодов символов 3263
            // выводит число т.к. выполняется операция сложения между символами, а не строками => соответственно берутся их коды

            Console.WriteLine("Читаю посимвольно по одному  {0}{1}{2}", str1[0],str1[3],str1[4]); // "сок"

            Console.WriteLine($"Сравнение str1==str2 {str1==str2}");
            Console.WriteLine($"Сравнение CompareTo {str1.CompareTo(str2)} и {str2.CompareTo(str1)} "); // стравнение выполянется попозиционно 
            Console.WriteLine($"Сравнение Compare {String.Compare(str1,str2)} и {String.Compare(str2,str1)} ");

            string strSpl = str2.Substring(9,3); // вырезали "Стр"
            Console.WriteLine(strSpl);

            Console.WriteLine(str1.GetType());

                  


            #endregion
        }
    }
}
