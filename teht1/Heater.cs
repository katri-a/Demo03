using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one instance of heater class 
            Heater heater = new Heater();
            heater.IsOn = true;
            heater.Temperature = 10;
            heater.Humidity = 5;

            heater.PrintData();

            //test changes
            heater.Heat(10);
            heater.SetMoist(3.09);

            heater.PrintData();


        }
    }
}
