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
        public bool IsAlive;

        public Character(string Name, int Health, int Mana, int Strenght)
        {
            this.Name = Name;
            this.Health = Health;
            this.Mana = Mana;
            this.Strenght = Strenght;
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
            return String.Format("Name = {0}\nHealth = {1}\nMana = {2}\nStrenght = {3}\nIsAlive = {4}\n", this.Name, this.Health, this.Mana, this.Strenght, this.IsAlive);
        }


    }
}
