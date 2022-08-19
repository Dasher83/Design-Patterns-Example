using Factory.Interfaces;
using Factory.Models;

namespace Factory.Models.Factories
{
    internal class ZeusHeroFactory : HeroFactory
    {
        public override IHero CreateHero()
        {
            return new ZeusHero();
        }
    }
}
