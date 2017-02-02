using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Heater
    {
        //properties 
        public bool IsOn { get; set; }
        public int Temperature { get; set; }
        public double Humidity { get; set; }

        public void Power(bool value)
        {
            IsOn = value;
        }


        public void Heat(int value)
        {
            Temperature += value;
        }

        public void SetMoist(double value)
        {
            Humidity += value;
        }
        public void PrintData()
        {
            Console.WriteLine("Heater mode: ");
            Console.WriteLine("Temperature: " + Temperature);
            Console.WriteLine("Humidity: " + Humidity);

        }
    }
}