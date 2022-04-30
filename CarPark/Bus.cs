﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class Bus : Car
    {
        private int FlightNumber = 0;

        public Bus(Motor Motor, Chassis Chassis, Transmission Transmission, int FlightNumber) : base(Motor, Chassis, Transmission)
        {
            if (FlightNumber > 0)
            {
                this.FlightNumber = FlightNumber;
            }
            else { Console.WriteLine("Введён некорректный номер маршрута."); }
        }

        public void Info()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Параметры автобуса:");
            if (this.FlightNumber != 0)
            {
                Console.WriteLine("\tНомер маршрута \t\t" + this.FlightNumber + "\n");
            }
            else { Console.WriteLine("Введён некорректный номер маршрута."); }
            
            base.Info();
            Console.WriteLine("----------------------------------------------");
        }
    }
}
