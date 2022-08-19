using Strategy.Interfaces;

namespace Strategy.Strategies.Sorting.Strings
{
    internal class StrategyAlphabetic : IStrategyStringSorting
    {
        public List<string> Sort(List<string> strings)
        {
            List<string> newStrings = new List<string>(strings);
            newStrings.Sort();
            return newStrings;
        }
    }
}
