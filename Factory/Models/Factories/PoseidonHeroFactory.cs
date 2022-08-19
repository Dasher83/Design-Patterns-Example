using Factory.Interfaces;
using Factory.Models;

namespace Factory.Models.Factories
{
    internal class PoseidonHeroFactory : HeroFactory
    {
        public override IHero CreateHero()
        {
            return new PoseidonHero();
        }
    }
}
