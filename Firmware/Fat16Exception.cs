using System;
using System.Collections.Generic;
using System.Text;

namespace Firmware
{
    public class Fat16Exception : Exception
    {
        public Fat16Exception(string msg)
            : base(msg)
        {
        }
    }
}
