using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    class Monster : Character
    {
        public Monster(string Name, int Health, int Mana, int Strenght, int Intelect) : base(Name, Health, Mana, Strenght, Intelect)
        {
        }
    }
}
