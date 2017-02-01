using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht6
{
    class Cd_player
    {
        public bool Power { get; set; }
        public int Track { get; set; }
        private static int maxVolume = 50;
        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (Power == false) volume = 0;
                else if (value <= maxVolume) volume = value;
                else volume = maxVolume;
            }
        }
        public Cd_player(bool power, int track, int volume)
        {
            Power = power;
            Track = track;
            Volume = volume;
        }
    }


}

