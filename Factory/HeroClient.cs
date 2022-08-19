using Factory.Interfaces;
using Factory.Models.Factories;

namespace Factory
{
    internal class HeroClient
    {
        public void ClientCode(HeroFactory factory)
        {
            IHero hero = factory.CreateHero();
            hero.ShowPowers();
        }
    }
}
