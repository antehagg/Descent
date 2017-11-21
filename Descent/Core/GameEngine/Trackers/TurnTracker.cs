using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Players;

namespace Descent.Core.GameEngine.Trackers
{
    public class TurnTracker
    {
        public int Turn;
        public List<Player> Players;

        private int _internalTurn;

        public TurnTracker(List<Player> players)
        {
            Turn = 1;
            Players = players;
            _internalTurn = 0;
        }

        public Player ActingPlayer()
        {
            return Players[_internalTurn];
        }

        public void NextInternalTurn()
        {
            if (_internalTurn == Players.Count)
                _internalTurn = 0;
            else
                _internalTurn++;
        }

        public void NextTurn()
        {
            Turn++;
        }
    }
}
