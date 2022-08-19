using TemplateMethod.BusinessEntities;


Game game = new Cricket();
game.TemplateExecutor.Play();
Console.WriteLine();
game = new Football();
game.TemplateExecutor.Play();