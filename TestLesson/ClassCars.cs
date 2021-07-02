using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestLessons
{
namespace CarDefenition { 
    enum Models { Mersedes, VW, Toyota, Honda, Porshe, Ford };
    
      internal class Car
        {
            public static string type = "Автомобиль"; // статическая переменная для всех экземпляров 
            public string regNum = "<Номер>"; // видимость в проекте
            private Models model = Models.Mersedes;                          // видимость в классе
            protected int maxSpeed = 100;                               // видимость в классе и наследниках
            public Car(string regNum, Models model, int maxSpeed = 200) //конструктор        
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
}


        internal class Bus : CarDefenition.Car //задаю класс наследник 
        {
            private byte seatsNum = 10;
            public Bus(string regNum2, CarDefenition.Models model2, int maxSpeed2, byte seats) : base(regNum2, model2, maxSpeed2)
            {
                seatsNum = seats;   // разные идентификаторы переменных поэтому можно и без this
                //maxSpeed = 150;     // protected переменная доступна и в наследнике и переопределится в наследник после инициализации Bus
                //maxSpeed2 = 250;    // уже поздно не сработает в base()
                type = "Бусик";
            }

            public override string ToString() // добавляю seatsNum
            {
                string str = base.ToString() + $" мест:{seatsNum} ";
                //Console.WriteLine(str);
                return str;
            }
        }


    
}
