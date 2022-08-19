using TemplateMethod.Utils;


namespace TemplateMethod.BusinessEntities
{
    internal class Cricket : Game
    {
        private ConsoleColor _color;

        public Cricket()
        {
            _color = RandomConsoleColorPicker.Pick;
        }

        public override void EndPlay()
        {
            ColorConsole.WriteLine("Cricket Game Finished!", _color);
        }

        public override void Initialize()
        {
            ColorConsole.WriteLine("Cricket Game Initialized! Start playing.", _color);
        }

        public override void StartPlay()
        {
            ColorConsole.WriteLine("Cricket Game Started. Enjoy the game!", _color);
        }
    }
}
