using Factory;
using Factory.Models.Factories;

HeroClient heroClient = new HeroClient();
heroClient.ClientCode(new ZeusHeroFactory());
Console.WriteLine();
heroClient.ClientCode(new PoseidonHeroFactory());
Console.WriteLine();