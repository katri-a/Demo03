using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            //instance
            TV tv = new TV(true, 30, 24);
            Console.WriteLine("TV is on {0}\nChannel {1}\nVolume {2}", tv.Power, tv.Channel, tv.Volume);
            TV tv2 = new TV(false, 402, 24);
            Console.WriteLine("TV is on {0}\nChannel {1}\nVolume {2}", tv2.Power, tv2.Channel, tv2.Volume);
            TV tv3 = new TV(false, 2, 24);
            Console.WriteLine("TV is on {0}\nChannel {1}\nVolume {2}", tv3.Power, tv3.Channel, tv3.Volume);
        }
    }
}
