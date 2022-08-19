using TemplateMethod.Interfaces;

namespace TemplateMethod.BusinessEntities
{
    internal sealed class GameTemplateExecutor : IGameTemplateExecutor
    {
        private IGame _game;

        public GameTemplateExecutor(IGame game)
        {
            _game = game;
        }

        public void Play()
        {
            _game.Initialize();
            _game.StartPlay();
            _game.EndPlay();
        }
    }
}
