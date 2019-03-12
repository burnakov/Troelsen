using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarEvents
{
    class CarEventArgs : EventArgs
    {
        public readonly string msg;

        CarEventArgs(string message)
        {
            msg = message;
        }
    }
}
