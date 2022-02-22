namespace Jogo_RPG.src.Entities
{
    public class Knight : Hero
    {
         public Knight(string Name, int Level, string HeroType, int maxHealthPoint, int MaxManaPoint) : base(Name, Level, HeroType, maxHealthPoint, MaxManaPoint)
        {
        }

        public override string Attack()
        {
            return this.Name + " " + "Attacked with a sword";
        }
    }
    
}