using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Washingmachine
    {
        public string Color { get; set; }
        public bool Window { get; set; }
        public bool Display { get; set; }
        public bool Timer { get; set; }
        public int WaterTemperature { get; set; }
        public int Wash_min { get; set; }

        public Washingmachine() {
            //default constructor can be left out
            }

        public Washingmachine(bool Display)  //constructor, machines have a display as default
        {
            Display = true;
        }

        
        //method
        public void wash()
        {
            Wash_min += 20;
        }

        public void PrintData() //method to display properties
        {
            Console.WriteLine("Washing machine data:\n");
            Console.WriteLine("- Color: " + Color);
            Console.WriteLine("- Window: " + Window);
            Console.WriteLine("- Display: " + Display);
            Console.WriteLine("- Timer: " + Timer);
            Console.WriteLine("- Water temperature: " + WaterTemperature);
            Console.WriteLine("- Time of the program in minutes: " + Wash_min);

        }

        //destructor
        ~Washingmachine()
        {
            Console.WriteLine("Object removed");
        }
    }
}
