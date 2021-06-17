
using System;
using System.Collections.Generic;

namespace TestLesson
{
    class Program
    {
        class Car
        {
            public static string type = "Автомобиль"; // статическая переменная для всех экземпляров 
            public string regNum = "<Номер>"; // видимость в проекте
            private string model = "Mersedes";                          // видимость в классе
            protected int maxSpeed = 100;                               // видимость в классе и наследниках
            public Car(string regNum, string model, int maxSpeed = 200) //конструктор        
            {
                this.regNum = regNum;
                this.model = model;
                this.maxSpeed = maxSpeed;
            }
            public Car() { }

            public override string ToString()
            {
                string str = $"{type} {model} {regNum} скорость:{maxSpeed}";
                //Console.WriteLine(str);
                return str;
            }
            public void Print() => Console.WriteLine(this.ToString());

        }


        class Bus : Car //задаю класс наследник 
        {
            private byte seatsNum = 10;
            public Bus(string regNum2, string model2, int maxSpeed2, byte seats) : base(regNum2, model2, maxSpeed2)
            {
                seatsNum = seats;   // разные идентификаторы переменных поэтому можно и без this
                maxSpeed = 150;     // protected переменная доступна и в наследнике и переопределится в наследник после инициализации Bus
                maxSpeed2 = 250;    // уже поздно не сработает в base()
                type = "Бусик";
            }

            public override string ToString() // добавляю seatsNum
            {
                string str = base.ToString() + $" мест:{seatsNum} " +;
                //Console.WriteLine(str);
                return str;
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Начинаем");
            #region Классы

            // определяю глобальные поля после инициализации

            Car def = new Car();
            def.regNum = "TT55EE";
            def.Print();

            Car.type = "Машина";
            Car toyota = new Car(regNum: "T532NE", model: "Toyota");
            toyota.Print();


            Bus sprinter = new Bus("T512EE", "Mers Sprinter", seats: 20, maxSpeed2: 200);
            sprinter.Print();

            Bus ikarus = new Bus("T123", "Ikarus", seats: 50, maxSpeed2: 120);
            Car.type = "Автобус"; // переопределяю дефолтный тип
            ikarus.Print();

            #endregion

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
            /*
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

          Console.WriteLine(str1.GetType()); //
          */
            #endregion

            #region Урок 3 /логический тип/ 
            //bool yes = true;
            //bool no = false;
            //Console.WriteLine($"1==2 ? { 1 == 2}");
            //Console.WriteLine($"1>=2 ?  { 1 >= 2}");
            //Console.WriteLine($"1<=2  ? { 1 <= 2}");
            //Console.WriteLine($"1>2  ? { 1 > 2}");
            //Console.WriteLine($"1<2  ? { 1 < 2}");


            //string name = Console.ReadLine();

            //switch (name)
            //{
            //    case "Игорь":
            //        name = "Игореха";
            //        break;
            //    case "Саша":
            //        name = "Сяня";
            //        break;
            //    case "Федор":
            //        name = "Федя";
            //        break;
            //    default:
            //        name = "ХЗ кто ты";
            //        break;
            //}

            //Console.WriteLine($"Здорово, {name}! Идем в магазин! ");
            //int totalMoney = 1000;
            //int minPrice = 20;
            //int maxPrice = 500;

            //List<int> log = new List<int>();// список покупок

            //Console.WriteLine("Введите цену товара");
            //while (totalMoney > minPrice)
            //{
            //    int price = 0;
            //    if (int.TryParse(Console.ReadLine(), out price))
            //    {
            //        if (price >= minPrice && price <= maxPrice && price < totalMoney)
            //        {
            //            log.Add(price);
            //            totalMoney -= price;
            //            Console.WriteLine($"Покупаем, остаток {totalMoney}");
            //        }
            //        else
            //        {
            //            if (price > maxPrice | price > totalMoney)
            //            {
            //                Console.WriteLine("Дороговато! Не покупаем");
            //            }
            //            else if (price < minPrice)
            //            {
            //                Console.WriteLine("Слишком дешевый товар нам не нужен!");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Что-то не то ввели, надо число!");
            //    }
            //}
            //for (int i = 0; i < log.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1}) Куплено на сумму {log[i]}");
            //}
            //Console.WriteLine($"Всего покупок {log.Count}"); log.RemoveRange(1, 3);
            //Console.WriteLine("Закончилось бабло! Остаток {0}", totalMoney);

            //Console.WriteLine("удалили 3 покупки, осталось" + log.Count);
            //foreach (int elem in log)
            //{
            //    Console.WriteLine(elem);
            //}

            #endregion
        }
    }
}
