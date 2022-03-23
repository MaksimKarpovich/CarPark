using System;
using System.Collections.Generic;
using System.Text;

namespace CarPark
{
    internal class Transmission
    {
        private string Type = "";
        private int NumberOfGears = 0;
        private string Creater = "";

        public Transmission(string type, int numberofgears, string creater) 
        {
            Type = type;
            NumberOfGears = numberofgears;
            Creater = creater;
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
