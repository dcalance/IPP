using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_ipp
{
    class GameOrder : Order
    {
        private Game game;
        public GameOrder(Game game)
        {
            this.game = game;
        }
        public void Execute()
        {
            game.play();
        }
    }
}
