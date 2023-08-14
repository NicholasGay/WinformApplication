using System;


namespace Bluetooth
{
    public class Sensor
    {
        public Sensor(string name, double data)
        {
            Name = name;
            Data = data;
        }

        public String Name { get; set; }
        public double Data { get; set; }


    }
}
