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
            if (NumberOfWheels > 0)
            {
                this.NumberOfWheels = NumberOfWheels;
            }
            else { Console.WriteLine("Введено некорректное значение количества колёс."); }

            if (LoadCapacity > 0)
            {
                this.LoadCapacity = LoadCapacity;
            }
            else { Console.WriteLine("Введено некорректное значение допустимой нагрузки."); }
     
            this.Number = Number;
        }

        public void Info()
        {
            if (this.NumberOfWheels != 0 && this.LoadCapacity != 0 && this.Number != "")
            {
                Console.WriteLine("Параметры шасси:");
                Console.WriteLine("\tКоличество колёс \t" + this.NumberOfWheels);
                Console.WriteLine("\tНомер \t\t\t" + this.Number);
                Console.WriteLine("\tДопустимая нагрузка \t" + this.LoadCapacity + "\n");
            }
            else { Console.WriteLine("Неверно введены параметры шасси.\n"); }
        }
    }
}
