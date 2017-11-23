using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descent.Gui.GameState
{
    public class State
    {
        public StateType Type;
    }

    public enum StateType { Init, Edit }
}
