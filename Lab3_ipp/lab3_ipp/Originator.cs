using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ipp
{
    class Originator
    {
        public string State { get; set; }

        public Memento saveStateToMememnto()
        {
            return new Memento(State);
        }
        public void getStateFromMemento(Memento mem)
        {
            State = mem.State;
        }
    }
}
