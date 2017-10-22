using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    class Character
    {
        public string Name;
        public int Health;
        public int Mana;
        public int Strenght;
        public int Intelect;
        public bool IsAlive;

        public Character(string Name, int Health, int Mana, int Strenght, int Intelect)
        {
            this.Name = Name;
            this.Health = Health;
            this.Mana = Mana;
            this.Strenght = Strenght;
            this.Intelect = Intelect;
            this.IsAlive = true;
        }

        public void PhysicalAttack(Character AttackedChar)
        {
            int damage = this.Strenght;

            if (damage >= AttackedChar.Health)
            {
                AttackedChar.Health = 0;
                AttackedChar.IsAlive = false;
            }
            else
            {
                AttackedChar.Health = AttackedChar.Health - damage;
            }
        }

        public override string ToString()
        {
            return String.Format("Name = {0}\nHealth = {1}\nMana = {2}\nStrenght = {3}\nIntelect = {4}\nIsAlive = {5}\n", this.Name, this.Health, this.Mana, this.Strenght, this.Intelect, this.IsAlive);
        }


    }
}
