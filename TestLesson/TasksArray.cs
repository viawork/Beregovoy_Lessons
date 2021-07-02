using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestLessons
{
    static class TasksArray // Д/з по массивам
    {
        static TasksArray() { }

        static int[] arr = { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
        static byte nTsk = 0;
        public static void Task1()
        {
            nTsk++;
            Console.WriteLine($"Task № {nTsk} ");
            Array.Sort(arr);
            Console.WriteLine($"Минимальный элемент  {arr[0]}");
            Console.WriteLine($"2-й способ Минимальный элемент  {arr.Min() }");
        }
        public static void Task2()
        {
            nTsk++;
            Console.WriteLine($"Task № {nTsk} ");
            //int[] arr = { 5, 12, 13, 2, 1, 9, 15, 19, 6 };
            Array.Sort(arr);
            Console.WriteLine($"2 максимальных элемента:  {arr[arr.Length - 1]} и {arr[arr.Length - 2]}");
            //Console.WriteLine($"2 максимальных элемента:  {arr.Max()} и {arr[arr.Max(]}");
        }
        public static void Task3()
        {
            nTsk++;
            Console.WriteLine($"Task № {nTsk} ");
            //int[] arr = { 5, 12, 13, 2, 1, 9, 15, 19, 6 };

            Console.WriteLine($"Сумма элементов:  {arr.Sum()} ");

            //2-й способ в лоб
            int aSumm = 0;
            foreach (var item in arr)
            {
                aSumm += item;
            }

            Console.WriteLine($"2-й способ Сумма элементов:  {aSumm} ");
        }

        public static void Task4() /// Заполнить массив по возрастанию от 1 до 100
        {
            nTsk++;
            Console.WriteLine($"Task № {nTsk} ");
            byte[] arr2 = new byte[100];
            for (int i = 0; i < 100; i++)
            {
                arr2[i] = (byte)(i + 1);
                Console.WriteLine($"arr2[{i}]={arr2[i]}");
            }

        }


        public static void Task5() /// Создать и заполнить массив случайными целыми числами
        {
            nTsk++;
            Console.WriteLine($"Task № {nTsk} ");
            int[] arrRnd = new int[25];
            Random rnd = new Random();
            for (int i = 0; i < arrRnd.Length; i++)
            {
                arrRnd[i] = rnd.Next(1, 500);
                Console.WriteLine(arrRnd[i]);
            }
        }
        public static void Task6() //Проверить, что в массиве нет одинаковых чисел
        {
            nTsk++;
            Console.WriteLine($"Task № {nTsk} ");
            Array.Sort(arr);
            bool dupl = false;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    Console.WriteLine($"Дублируются элементы ({i},{i - 1}) {arr[i]} и {arr[i - 1]}");
                    dupl = true;
                }
            }
            if (!dupl)
                Console.WriteLine("Нет дублирований");

        }
        public static void Task7()//Переставить элементы массива arr в обратном порядке используя вспомогательный массив
        {
            nTsk++;
            Console.WriteLine($"Task № {nTsk} ");
            int[] arrRevers = new int[arr.Length]; // создаю массимв такого же размера
            for (int i = 0; i < arr.Length; i++)
            {
                arrRevers[arr.Length - 1 - i] = arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("\t" + arr[i] + " \t" + arrRevers[i]);
            }

        }
        public static void Task8() //Переставить элементы массива в обратном порядке НЕ используя вспомогательный массив
        {
            nTsk++;
            Console.WriteLine($"Task № {nTsk} ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("До " + arr[i]);
            }
            int val;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                val = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = val;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("После " + arr[i]);
            }

        }

        static int[,] m2 = new int[,] { { 11, 22, 31 }, { 4, 53, 6 }, { 7, 81, 90 } };
        public static void Task9()
        {
            nTsk++;
            Console.WriteLine($"Task № {nTsk} ");
            int m2Summ = 0;
            foreach (var item in m2)
            {
                m2Summ += item;
            }
            Console.WriteLine("Сумма =" + m2Summ);
            // 
            m2Summ = 0;
            for (int i = 0; i < m2.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    m2Summ += m2[i, j];
                }
            }

            Console.WriteLine("Сумма 2=" + m2Summ);


        }
        public static void Task10() //Заполнить двумерный массив 10 на 10 случайными числами от 1 до 9 и вывести на экран консоли
        {
            nTsk++;
            Console.WriteLine($"Task № {nTsk} ");
            int[,] arr2 = new int[10, 10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr2[i, j] = rnd.Next(1, 9);
                }
            }
            byte ii = 0;
            foreach (var item in arr2)
            {
                Console.Write($"\t{item}");
                ii++;
                if (ii == 10)
                {
                    ii = 0;
                    Console.WriteLine(); // перевод строки
                }
            }

        }
        public static void Task11()
        {
            nTsk++;
            Console.WriteLine($"Task № {nTsk} ");
            int[] arr = new int[m2.Length];
            int cnt = 0;
            foreach (var item in m2)
            {
                arr[cnt] = item;
                Console.WriteLine(arr[cnt]);
            }
        }
        public static void Task12()/// Заполнить двумерный массив 10 на 10 случайными числами от 1 до 99 и определить количество четных чисел в массиве
        {
            nTsk++;
            Console.WriteLine($"Task № {nTsk} ");
            int[,] arr2 = new int[10, 15];
            Random rnd = new Random();

            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    arr2[i, j] = rnd.Next(1, 99);
                }
            }
            byte ii = 0;
            byte cntPar = 0; // счетчик четных
            foreach (var item in arr2)
            {
                if (item % 2 == 0)
                {
                    cntPar++;
                }
                Console.Write($"\t{item}");
                ii++;
                if (ii == 10)
                {
                    ii = 0;
                    Console.WriteLine(); // перевод строки
                }
            }
            Console.WriteLine($"\nЧетных чисел {cntPar} \nНЕчетных чисел { arr2.Length - cntPar} ");

        }
    }
}
