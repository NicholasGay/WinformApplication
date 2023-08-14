namespace Bluetooth
{
    internal static class Receving_Config_Constants
    {
        public const byte START_BYTE = 0xA5;
        public const byte END_BYTE = 0x5A;
        public const int MESSAGE_LENGTH = 7;
        
    }
    
    internal static class File_Config_Constants
    {
        public const string FILE_PATH = "temperature_data.txt";
    }
}
