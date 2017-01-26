using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        //properties auton ominaisuuksia
        public string Model { get; set; } //accessori aaltosulut, voidaan asettaa arvo sai kysyä
        public string Color { get; set; }
        public double Engine { get; set; }
       public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }
        public static int SomeProperty { get; set; }

        //default constructor
        public Car()
        {

        }

        //constructor
        public Car(string model)
        {
            Model = model;  //property isolla parametri pienellä
        }

        //method to give more speed
        public void Accelerate()
        {
            Speed += 10;
        }

        //method to slow down
        public void Break(int value)
        {
            Speed -= value; //joku muu määrittää paljon hidastaa
        }

        //method to display car properties
        public void PrintData()
        {
            Console.WriteLine("Car data:");
            Console.WriteLine("- model:" + Model);
            Console.WriteLine("- color:" + Color);
            Console.WriteLine("- engine:" + Engine);
            Console.WriteLine("- speeed:" + Speed);
            Console.WriteLine("- fuzzydices:" + FuzzyDices);
            Console.WriteLine("- doors:" + DoorCount);
            Console.WriteLine("- some static property:" + SomeProperty);

        }

        //destructor
        ~Car()
        {
            Console.WriteLine("Car object removed");
        }

    }

}
