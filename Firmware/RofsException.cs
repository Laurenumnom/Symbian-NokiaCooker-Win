using System;
using System.Collections.Generic;
using System.Text;

namespace Firmware
{
    public class RofsException : Exception
    {
        public RofsException(string msg)
            : base(msg)
        {
        }
    }
}
