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

        public void MagicalAttack(Character AttackedChar)
        {
            int damage = this.Intelect;

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

        public void Buff(Character BuffedChar, Attributes Attr, int Value)
        {
            switch (Attr)
            {
                case Attributes.Health:
                    BuffedChar.Health = BuffedChar.Health + Value;
                    break;
                case Attributes.Intelect:
                    BuffedChar.Intelect = BuffedChar.Intelect + Value;
                    break;
                case Attributes.Mana:
                    BuffedChar.Mana = BuffedChar.Mana + Value;
                    break;
                case Attributes.Strenght:
                    BuffedChar.Strenght = BuffedChar.Strenght + Value;
                    break;
            }
        }

        public void Debuff(Character DebuffedChar, Attributes Attr, int Value)
        {
            switch (Attr)
            {

                case Attributes.Health:
                    if (Value >= DebuffedChar.Health)
                    {
                        DebuffedChar.Health = 0;
                        DebuffedChar.IsAlive = false;
                    }
                    else
                    {
                        DebuffedChar.Health = DebuffedChar.Health - Value;
                    }
                    break;
                case Attributes.Intelect:
                    DebuffedChar.Intelect = DebuffedChar.Intelect - Value;
                    break;
                case Attributes.Mana:
                    DebuffedChar.Mana = DebuffedChar.Mana - Value;
                    break;
                case Attributes.Strenght:
                    DebuffedChar.Strenght = DebuffedChar.Strenght + Value;
                    break;
            }
        }

        public void Buff(Attributes Attr, int Value)
        {
            this.Buff(this, Attr, Value);
        }

        public void Debuff(Attributes Attr, int Value)
        {
            this.Debuff(this, Attr, Value);
        }

        public override string ToString()
        {
            return String.Format("Name = {0}\nHealth = {1}\nMana = {2}\nStrenght = {3}\nIntelect = {4}\nIsAlive = {5}\n", this.Name, this.Health, this.Mana, this.Strenght, this.Intelect, this.IsAlive);
        }


    }
}
