using TemplateMethod.Interfaces;


namespace TemplateMethod.BusinessEntities
{
    internal abstract class Game : IGame
    {
        private readonly IGameTemplateExecutor _templateExecutor;

        public Game()
        {
            _templateExecutor = new GameTemplateExecutor(this);
        }

        public IGameTemplateExecutor TemplateExecutor { get { return _templateExecutor; } }
        abstract public void Initialize();
        abstract public void StartPlay();
        abstract public void EndPlay();
    }
}
