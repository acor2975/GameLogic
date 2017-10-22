using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    class Monster : Character
    {
        public Monster(string Name, int Health, int Mana, int Strenght) : base(Name, Health, Mana, Strenght)
        {
        }
    }
}
