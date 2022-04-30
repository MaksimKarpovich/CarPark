﻿using System;

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
            Motor m5 = new Motor(40.5, -2.3, "Assinchrone", "i93u52s");

            Chassis c1 = new Chassis(4, "num1", 320.0);
            Chassis c2 = new Chassis(6, "num2", 640.0);
            Chassis c3 = new Chassis(8, "num3", 580.0);
            Chassis c4 = new Chassis(2, "num4", 110.0);
            Chassis c5 = new Chassis(2, "", 110.0);

            Transmission t1 = new Transmission("t1", 4, "Siemens");
            Transmission t2 = new Transmission("t2", 6, "Siemens");
            Transmission t3 = new Transmission("t3", 4, "Siemens");
            Transmission t4 = new Transmission("t4", 2, "Siemens");
            Transmission t5 = new Transmission("t5", 2, "Siemens");

            PassengerCar car1 = new PassengerCar(m1, c1, t1, 2);
            Truck car2 = new Truck(m2, c2, t2, 150);
            Bus car3 = new Bus(m3, c3, t3, 14);
            Scooter car4 = new Scooter(m4, c4, t4, 2);
            Scooter car5 = new Scooter(m5, c5, t5, 2);

            car1.Info();
            car2.Info();
            car3.Info();
            car4.Info();
            car5.Info();
        }
    }
}
