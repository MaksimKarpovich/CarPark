using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class Scooter : Car
    {
        private int NumberMirrors = 0;

        public Scooter(Motor Motor, Chassis Chassis, Transmission Transmission, int NumberMirrors) : base(Motor, Chassis, Transmission)
        {
            if (NumberMirrors > 0)
            {
                this.NumberMirrors = NumberMirrors;
            }
            else { Console.WriteLine("Введено некорректное число зеркал."); }
        }

        public void Info()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Параметры автобуса:");
            if (this.NumberMirrors != 0)
            {
                Console.WriteLine("\tКоличество зеркал \t" + this.NumberMirrors + "\n");
            }
            else { Console.WriteLine("Введено некорректное число зеркал."); }
            
            base.Info();
            Console.WriteLine("----------------------------------------------");
        }
    }
}
