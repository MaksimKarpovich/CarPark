using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class Chassis
    {
        private int NumberOfWheels = 0;
        private string Number = "";
        private double LoadCapacity = 0.0;

        public Chassis(int numberofwheels, string number, double loadcapacity) 
        {
            NumberOfWheels = numberofwheels;
            Number = number;
            LoadCapacity = loadcapacity;
        }

        public void Info()
        {
            Console.WriteLine("Параметры шасси:");
            Console.WriteLine("\tКоличество колёс \t" + this.NumberOfWheels);
            Console.WriteLine("\tНомер \t\t\t" + this.Number);
            Console.WriteLine("\tДопустимая нагрузка \t" + this.LoadCapacity + "\n");
        }
    }
}
