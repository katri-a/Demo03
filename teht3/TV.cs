using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class TV
    {
        public bool Power { get; set; }
        private static int maxChannel = 400;
        private int channel;
        public int Channel
        {
            get { return channel; }
            set
            {
                if (Power == false) channel = 0;
                else if (value <= maxChannel) channel = value;
                else channel = maxChannel;
            }
        }
        private int volume;
        public int Volume
        {
            get { return volume; }
            set
            {
                if (Power == false) volume = 0;
                else volume = Volume;
            }
        }

        //method to display properties
        public TV (bool power, int channel, int volume)
        {
            Power = power;
            Channel = channel;
            Volume = volume;
        }
    }
}
