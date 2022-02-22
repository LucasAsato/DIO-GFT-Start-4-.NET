namespace Jogo_RPG.src.Entities
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public int Level { get; set; } 
        public string HeroType { get; set; }
        public int HealthPoint { get; set; }
        public int ManaPoint { get; set;}
        public int MaxHealthPoint { get; set; }
        public int MaxManaPoint { get; set; }

        public Hero (string Name, int Level, string HeroType, int maxHealthPoint, int MaxManaPoint)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HealthPoint = maxHealthPoint;
            this.MaxHealthPoint = maxHealthPoint;
            this.ManaPoint = MaxManaPoint;
            this.MaxManaPoint = MaxManaPoint;
        }

        public virtual string Block(int Attack, int Block)
        {
            if (Attack > Block)
            {
                this.HealthPoint = this.HealthPoint - (Attack - Block);
            }
            else 
            {
                Block = Attack;
            }
            return this.Name + " " + "suffer an attack of " + Attack +
                    " blocked " + Block + " and now has " + HealthPoint; 
        }
        public virtual string Attack()
        {
            return "";
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + HeroType + "\n" ;
        }
    }
}