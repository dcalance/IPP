using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ipp
{
    class Memento
    {
        public string State { get; }
        public Memento(string state)
        {
            State = state;
        }
    }
}
