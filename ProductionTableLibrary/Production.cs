using System;

namespace ProductionTableLibrary
{

    public class Table // таблица умножения видна и  в дуругом проекте
        {
            byte x = 5;
            byte y = 7;
            int[,] tbl;
            public Table()
            {
                tbl = new int[x + 1, y + 1];

                CreateTbl();
            }
            public Table(byte x, byte y)
            {
                this.x = x;
                this.y = y;
                tbl = new int[x + 1, y + 1];
                CreateTbl();
            }
            void CreateTbl()
            {
                for (var i = 1; i <= x; i++)
                {
                    for (int j = 1; j <= y; j++)
                    {
                        tbl[i, j] = i * j;
                    }
                }
            }

            public void Print()
            {
                for (int j = 1; j <= y; j++)
                {
                    Console.Write($"\t{j}");
                }

                for (var i = 1; i <= x; i++)
                {
                    Console.Write($"\n{i}"); //порядковый номер строки
                    for (int j = 1; j <= y; j++)
                    {
                        Console.Write($"\t{tbl[i, j]}");
                    }
                }
            }


        }
        
     
}
