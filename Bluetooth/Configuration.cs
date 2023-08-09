using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bluetooth
{
    internal static class Receving_Config_Constants
    {
        public const byte START_BYTE = 0xA5;
        public const byte END_BYTE = 0x5A;
        public const int MESSAGE_LENGTH = 7;
    }
}
