namespace Jogo_RPG.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int maxHealthPoint, int MaxManaPoint) : base(Name, Level, HeroType, maxHealthPoint, MaxManaPoint)
        {
        }

        public override string Attack()
        {
            return this.Name + " " + "Attacked with a kunai";
        }
    }

    
}