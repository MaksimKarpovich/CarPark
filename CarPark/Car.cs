using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class Car
    {
        private string Name;
        private Motor m;
        private Chassis c;
        private Transmission t;

        public Car(Motor motor, Chassis chassis, Transmission tra, string name) 
        {
            m = motor;
            c = chassis;
            t = tra;
            Name = name;
        }

        public void Info() 
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Параметры сущности \'" + this.Name + "\':\n");
            this.m.Info();
            this.c.Info();
            this.t.Info();
            Console.WriteLine("----------------------------------------------");
        }


    }
}
