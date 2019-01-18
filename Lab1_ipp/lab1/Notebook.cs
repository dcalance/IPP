using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Notebook : Computer
    {
        public string hdd { get; set; }
        public string ram { get; set; }
        public bool isBluetoothEnabled { get; set; }
        public bool isGraphicsCardEnabled { get; set; }
        public void whatIsThis()
        {
            Console.WriteLine("This is a Notebook");
        }
        public Notebook(ComputerBuilder builder)
        {
            this.hdd = builder.hdd;
            this.ram = builder.ram;
            this.isBluetoothEnabled = builder.isBluetoothEnabled;
            this.isGraphicsCardEnabled = builder.isGraphicsCardEnabled;
        }
    }
}
