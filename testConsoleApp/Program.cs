using System;

namespace testConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UInt32 i = 0xCAFEBABE;
            Console.WriteLine(Firmware.BytesUtils.SwapBytes(i).ToString("X8"));
        }
    }
}
