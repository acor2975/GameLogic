using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    abstract class Skill
    {
        public int Power;
        public int Cooldown;

        abstract public void Effect(Character User, Character Target, int Modifier);

        public Skill(int Power, int Cooldown)
        {
            this.Power = Power;
            this.Cooldown = Cooldown;
        }
    }
}
