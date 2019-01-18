using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class ComputerBuilder
    {
        public string hdd;
        public string ram;
        public bool isGraphicsCardEnabled;
        public bool isBluetoothEnabled;

        public ComputerBuilder setGraphicsCardEnabled(bool newValue)
        {
            this.isGraphicsCardEnabled = newValue;
            return this;
        }
        public ComputerBuilder setBluetoothEnabled(bool newValue)
        {
            this.isBluetoothEnabled = newValue;
            return this;
        }
        public ComputerBuilder setHDD(string newValue)
        {
            this.hdd = newValue;
            return this;
        }
        public ComputerBuilder setRAM(string newValue)
        {
            this.ram = newValue;
            return this;
        }
        public PC buildPC()
        {
            return new PC(this);
        }

        public Notebook buildNotebook()
        {
            return new Notebook(this);
        }

    }
}
