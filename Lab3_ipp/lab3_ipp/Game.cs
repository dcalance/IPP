using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ipp
{
    abstract class Game
    {
        protected abstract void Initialize();
        protected abstract void StartPlay();
        protected abstract void EndPlay();
        
        public void play()
        {
            Initialize();
            StartPlay();
            EndPlay();
        } 
    }
}
