using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace WpfSmartMedicine.src
{
    abstract class DeviceBase
    {
        private const string DllPath = "Dlls\\Dll1.dll";


        [DllImport(DllPath, EntryPoint = "InitPort", CallingConvention = CallingConvention.Winapi)]
        public static extern bool InitPort(ushort portNo, ushort baud, char parity, ushort databits, ushort stopsbits, ulong dwCommEvents);
    }
}
