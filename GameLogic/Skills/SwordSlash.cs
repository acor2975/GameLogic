using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Skills
{
    class SwordSlash : Skill
    {
        public SwordSlash(int Power, int Cooldown) : base(Power, Cooldown)
        {
        }

        public override void Effect(Character User, Character Target, int Modifier)
        {
            User.PhysicalAttack(Target, Modifier);
        }
    }
}
