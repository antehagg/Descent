using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Players
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Ai { get; set; }
        public List<PlayingHero> PlayedHeroes { get; set; }
    }
}
