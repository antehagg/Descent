using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Descent.Core.GameEngine.Random
{
    public class RandomDice
    {
        private readonly System.Random _random;

        public RandomDice()
        {
            _random = new System.Random();
        }

        public int Roll(int max)
        {
            return _random.Next(0, max);
        }
       
    }
}
