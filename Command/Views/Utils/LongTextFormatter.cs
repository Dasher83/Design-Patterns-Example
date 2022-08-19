using System.Text;

namespace Command.Views.Utils
{
    internal static class LongTextFormatter
    {
        public static string AddLineBreaks(string originalText, uint wordsPerLine = 20)
        {
            string text = new StringBuilder(originalText).ToString();
            StringBuilder lines = new StringBuilder();
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            List<string> totalWords = new List<string>(
                text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries));
            List<string> line = new List<string>();
            while (totalWords.Count > 0)
            {
                line.Clear();
                if(totalWords.Count < wordsPerLine)
                {
                    wordsPerLine = (uint)totalWords.Count;
                }

                for(int i = 0; i < wordsPerLine; i++)
                {
                    line.Add(totalWords.ElementAt(0));
                    totalWords.RemoveAt(0);
                }
                lines.AppendLine(String.Join(" ", line));
            }
            return lines.ToString();
        }
    }
}
