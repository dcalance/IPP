using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public interface Computer
    {
        string hdd { get; set; }
        string ram { get; set; }
        bool isBluetoothEnabled { get; set; }
        bool isGraphicsCardEnabled { get; set; }
        void whatIsThis();
    }
}
