using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic.Skills
{
    class StaffAttack : Skill
    {
        public StaffAttack(int Power, int Cooldown) : base(Power, Cooldown)
        {
        }

        public override void Effect(Character User, Character Target, int Modifier)
        {
            User.MagicalAttack(Target, Modifier);
        }
    }
}
