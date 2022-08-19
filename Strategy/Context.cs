using Strategy.Interfaces;
using Strategy.Utils;

namespace Strategy
{
    internal class Context
    {
        private IStrategyStringSorting? _strategy;

        public Context() { }

        public Context(IStrategyStringSorting strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategyStringSorting strategy)
        {
            _strategy = strategy;
        }

        public void DoSomeBusinessLogic()
        {
            if (_strategy == null)
            {
                throw new NullReferenceException(nameof(_strategy));
            }
            ConsoleColor color = RandomConsoleColorPicker.Pick;
            ColorConsole.WriteLine(
                "Context: Sorting strings using the strategy (not sure how it'll do it)", color);
            List<string> result = _strategy.Sort(new List<string> { "a", "c", "b", "d", "e" });
            ColorConsole.WriteLine(string.Join(", ", result), color);
        }
    }
}
