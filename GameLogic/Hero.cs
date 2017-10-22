using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    class Hero : Character
    {
        public Hero(string Name, int Health, int Mana, int Strenght, int Intelect) : base(Name, Health, Mana, Strenght, Intelect)
        {
        }
    }
}
