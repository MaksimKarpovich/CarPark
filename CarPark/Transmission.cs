using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    /// <summary>
    /// Класс, описывающий элемент трансмиссии
    /// </summary>
    internal class Transmission
    {
        private string Type = "";
        private int NumberOfGears = 0;
        private string Creater = "";

        public Transmission(string Type, int NumberOfGears, string Creater) 
        {
            this.Type = Type;
            this.NumberOfGears = NumberOfGears;
            this.Creater = Creater;
        }

        public void Info()
        {
            Console.WriteLine("Параметры трансмиссии:");
            Console.WriteLine("\tТип \t\t\t" + this.Type);
            Console.WriteLine("\tКоличество передач \t" + this.NumberOfGears);
            Console.WriteLine("\tпроизводитель \t\t" + this.Creater + "\n");
        }
    }
}
