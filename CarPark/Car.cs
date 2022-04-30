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
        protected Motor Motor;
        protected Chassis Chassis;
        protected Transmission Transmission;

        public Car(Motor Motor, Chassis Chassis, Transmission Transmission) 
        {
            this.Motor = Motor;
            this.Chassis = Chassis;
            this.Transmission = Transmission;
        }

        public void Info() 
        {
            this.Motor.Info();
            this.Chassis.Info();
            this.Transmission.Info();
        }


    }
}
