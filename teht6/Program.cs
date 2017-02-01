using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Program
    {
        static void Main(string[] args)
        {
            Cd_player cd = new Cd_player(true, 1, 11);
            Console.WriteLine("Cd player is on -  {0}\nTrack number: {1}\nVolume {2}\n", cd.Power, cd.Track, cd.Volume);


        }
    }
}
