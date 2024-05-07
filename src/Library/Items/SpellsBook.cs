using System.Collections.Generic;

namespace RoleplayGame
{
    public class SpellsBook
    {
        public Spell[] spells { get; set; }
        
        public int AttackValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.spells)
                {
                    value += spell.AttackValue;
                }
                return value;
            }
        }

        public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (Spell spell in this.spells)
                {
                    value += spell.DefenseValue;
                }
                return value;
            }
        }
    }
}