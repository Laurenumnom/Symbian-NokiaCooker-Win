using System;
using System.Collections.Generic;
using System.Text;


namespace Firmware
{
    public class FwException : Exception
    {
        public FwException(string msg)
            : base(msg)
        {
        }
    }
}
