using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    /// <summary>
    /// Класс, описывающий элемент машина
    /// </summary>
    internal class Car
    {
        private string Name;
        private Motor Motor;
        private Chassis Chassis;
        private Transmission Transmission;

        public Car(Motor Motor, Chassis Chassis, Transmission Transmission, string Name) 
        {
            this.Motor = Motor;
            this.Chassis = Chassis;
            this.Transmission = Transmission;
            this.Name = Name;
        }

        public void Info() 
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Параметры сущности \'" + this.Name + "\':\n");
            this.Motor.Info();
            this.Chassis.Info();
            this.Transmission.Info();
            Console.WriteLine("----------------------------------------------");
        }


    }
}
