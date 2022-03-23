using System;

namespace CarPark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Motor m1 = new Motor(40.5, 2.3, "Assinchrone", "d14f52f");
            Motor m2 = new Motor(150.7, 4.5, "Assinchrone", "g53t74h");
            Motor m3 = new Motor(120.7, 4.0, "Assinchrone", "q14u46o");
            Motor m4 = new Motor(40.5, 2.3, "Assinchrone", "h63g25g");

            Chassis c1 = new Chassis(4, "num1", 320.0);
            Chassis c2 = new Chassis(6, "num2", 640.0);
            Chassis c3 = new Chassis(8, "num3", 580.0);
            Chassis c4 = new Chassis(2, "num4", 110.0);

            Transmission t1 = new Transmission("t1", 4, "Siemens");
            Transmission t2 = new Transmission("t2", 6, "Siemens");
            Transmission t3 = new Transmission("t3", 4, "Siemens");
            Transmission t4 = new Transmission("t4", 2, "Siemens");

            Car car1 = new Car(m1, c1, t1, "Легковой автомобиль");
            Car car2 = new Car(m2, c2, t2, "Грузовик");
            Car car3 = new Car(m3, c3, t3, "Автобус");
            Car car4 = new Car(m4, c4, t4, "Скутер");

            car1.Info();
            car2.Info();
            car3.Info();
            car4.Info();
        }
    }
}
