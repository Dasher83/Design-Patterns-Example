using Command.Interfaces;
using Command.Views.Utils;

namespace Command.Views
{
    internal class MainTextView
    {
        private IEditor _editor;
        private string _clipboard;

        public MainTextView(IEditor editor, string clipboard)
        {
            _editor = editor;
            _clipboard = clipboard;
        }

        public void Show()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The Extremely primitive text editor");
            Console.WriteLine();
            if(_editor.Text.Length > 0) {
                Console.WriteLine("The following is the text in the editor:");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no text in the editor yet, use the options to fill it:");
                Console.ResetColor();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{LongTextFormatter.AddLineBreaks(_editor.Text)}");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if(_editor.GetSelection().Length > 0)
            {
                Console.WriteLine("From the original text you have selected the following:");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"\"{_editor.GetSelection()}\"");
                Console.WriteLine($"(Indexes: {_editor.TextSelection.start} - {_editor.TextSelection.end})");
            } 
            else
            {
                Console.WriteLine("Nothing has been selected from the origina text for now...");
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (_clipboard.Length > 0)
            {
                Console.WriteLine("Clipboard's content:");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\"{_clipboard}\"");
            }
            else
            {
                Console.WriteLine("The clipboard is empty for now...");
            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
