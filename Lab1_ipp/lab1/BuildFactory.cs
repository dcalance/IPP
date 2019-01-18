using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class BuildFactory
    {
        private static BuildFactory instance = null;
        private BuildFactory()
        {
        }

        public PC buildGenericPC()
        {
            ComputerBuilder builder = new ComputerBuilder();
            return builder.setHDD("0").setRAM("0").setBluetoothEnabled(true).buildPC();
        }

        public Notebook buildGenericNotebook()
        {
            ComputerBuilder builder = new ComputerBuilder();
            return builder.setHDD("0").setRAM("0").setBluetoothEnabled(true).buildNotebook();
        }

        public static BuildFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BuildFactory();
                }
                return instance;
            }
        }
    }
}
