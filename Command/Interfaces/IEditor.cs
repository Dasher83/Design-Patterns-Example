using Command.Structs;

namespace Command.Interfaces
{
    internal interface IEditor
    {
        public string Text { get; set; }
        public string TextToAdd { get; set; }
        public TextSelection TextSelection { get; }
        public void Select(int start, int end);
        public string GetSelection();
        public void DeleteSelection();
        public void ReplaceSelection(string text);
    }
}
