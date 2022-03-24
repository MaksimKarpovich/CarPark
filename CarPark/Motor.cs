using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    /// <summary>
    /// Класс, описывающий элемент двигатель
    /// </summary>
    internal class Motor
    {
        private double Power = 0;
        private double Volume = 0;
        private string Type = "";
        private string SerialNumer = "";

        public Motor(double Power, double Volume, string Type, string Serial) 
        {
            this.Power = Power;
            this.Volume = Volume;
            this.Type = Type;
            this.SerialNumer = Serial;
        }

        public void Info() 
        {
            Console.WriteLine("Параметры двигателя:");
            Console.WriteLine("\tМощность \t\t" + this.Power);
            Console.WriteLine("\tОбъём \t\t\t" + this.Volume);
            Console.WriteLine("\tТип \t\t\t" + this.Type);
            Console.WriteLine("\tСерийный номер \t\t" + this.SerialNumer + "\n");
        }
    }
}
