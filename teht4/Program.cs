using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Program
    {
        static void Main(string[] args)
        
            {
            Vehicle car = new Vehicle("Car", 40, 4);
            Console.WriteLine("Vehicle = {0}\nSpeed = {1}\nTyres = {2}\n",  Vehicle.name, Vehicle.speed, Vehicle.tyres);

        //    object car = new Vehicle();
          //  Console.WriteLine(car.ToString());
            }

        
    }
}
