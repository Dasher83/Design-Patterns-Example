using TemplateMethod.Utils;


namespace TemplateMethod.BusinessEntities
{
    internal class Football : Game
    {
        private ConsoleColor _color;

        public Football()
        {
            _color = RandomConsoleColorPicker.Pick;
        }

        public override void EndPlay()
        {
            ColorConsole.WriteLine("Football Game Finished!", _color);
        }

        public override void Initialize()
        {
            ColorConsole.WriteLine("Football Game Initialized! Start playing.", _color);
        }

        public override void StartPlay()
        {
            ColorConsole.WriteLine("Football Game Started. Enjoy the game!", _color);
        }
    }
}
