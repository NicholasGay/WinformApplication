using System;


namespace Bluetooth
{
    internal class Sensor
    {
        public Sensor(string name, byte Upper_Byte, byte Lower_Byte)
        {
            Name = name;
            set_data(Lower_Byte, Upper_Byte);
        }

        public String Name { get; set; }
        private float Data { get; set; }

        public void set_data(byte Lower_byte, byte Upper_byte)
        {
            byte[] byteArray = new byte[] { Upper_byte, Lower_byte, 0X00,0X00 }; //tEMPORATY SOLUTION
            Data = BitConverter.ToSingle(byteArray, 0);
        }

        public float get_data()
        {
            return Data;
        }
    }
}
