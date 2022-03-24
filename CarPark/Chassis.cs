using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    /// <summary>
    /// Класс, описывающий элемент шасси
    /// </summary>
    internal class Chassis
    {
        private int NumberOfWheels = 0;
        private string Number = "";
        private double LoadCapacity = 0.0;

        public Chassis(int NumberOfWheels, string Number, double LoadCapacity) 
        {
            this.NumberOfWheels = NumberOfWheels;
            this.Number = Number;
            this.LoadCapacity = LoadCapacity;
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
