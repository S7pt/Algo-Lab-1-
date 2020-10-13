using System;
using System.Collections.Generic;
using System.Text;

namespace Algo_lab_1.src.model
{
    public class Perforator
    {
        public string color;
        public int revolutionsPerMinute;
        public int strokeFrequency;
        public string producerName;

        public Perforator(string color, int revolutionsPerMinute, int strokeFrequency, string producerName)
        {
            this.color = color;
            this.revolutionsPerMinute = revolutionsPerMinute;
            this.strokeFrequency = strokeFrequency;
            this.producerName = producerName;
        }
        public override string ToString()
        {
            return "color: " + color + ", RPM: " + revolutionsPerMinute + 
                ", stroke frequency: " + strokeFrequency + ", producer name: " + producerName;
        }
    }
}
