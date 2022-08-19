using Factory.Interfaces;

namespace Factory.Models.Factories
{
    internal abstract class HeroFactory
    {
        public abstract IHero CreateHero();
    }
}
