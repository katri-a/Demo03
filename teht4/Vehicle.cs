using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht4
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData(string name, int speed, int tyres)
        {
            Console.WriteLine("Vehicle data:" + name, speed, tyres);
            Name = name;
            Speed = speed;
            Tyres = tyres;

        }
    }
}
