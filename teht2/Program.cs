using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance
            Washingmachine washingmachine = new Washingmachine();
            washingmachine.PrintData();
            washingmachine.Color = "silver";
            washingmachine.Display = true;
            washingmachine.Timer = true;
            washingmachine.Window = false;
            washingmachine.WaterTemperature = 40;
            washingmachine.PrintData();

            Washingmachine quickwash = new teht2.Washingmachine();
            quickwash.PrintData();
            quickwash.Display = true;
            quickwash.Timer = true;
            quickwash.Window = false;
            quickwash.WaterTemperature = 30;
            quickwash.Wash_min = 20;
            quickwash.PrintData();

            Washingmachine whirlpool = new teht2.Washingmachine();
            whirlpool.PrintData();
            whirlpool.Color = "White";
            whirlpool.Display = true;
            whirlpool.Timer = true;
            whirlpool.Window = false;
            whirlpool.WaterTemperature = 30;
            whirlpool.wash();
            Console.WriteLine("Washing minutes: " + whirlpool.Wash_min);
            washingmachine.PrintData();
        }
    }
}
