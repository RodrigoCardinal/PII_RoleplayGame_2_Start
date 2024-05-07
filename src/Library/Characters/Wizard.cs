namespace RoleplayGame
{
    public class Wizard
    {
        private int health = 100;

        public Wizard(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public SpellsBook spellsBook { get; set; }

        public Staff staff { get; set; }

        public int AttackValue
        {
            get
            {
                return spellsBook.AttackValue + staff.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return spellsBook.DefenseValue + staff.DefenseValue;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}