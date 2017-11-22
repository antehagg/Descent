using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Characters.HeroData;

namespace DataLib.Characters
{
    public class Character : ICharacter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Characteristics Characteristics { get; set; }
    }
}
