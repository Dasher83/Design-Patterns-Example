using Command.Interfaces;
using Command.Structs;

namespace Command
{
    internal class Editor: IEditor
    {
        private string _text;
        private string _textToAdd;
        private TextSelection _textSelection;

        public Editor()
        {
            _text = "";
            _textToAdd = "";
            _textSelection = new TextSelection();
        }

        public string Text { get { return _text.Trim(); } set { _text = value.Trim(); } }

        public string TextToAdd { get { return _textToAdd.Trim(); } set { _textToAdd = value.Trim(); } }

        public TextSelection TextSelection { get { return _textSelection; }}

        public void Select(int start, int end)
        {
            _textSelection.start = start;
            _textSelection.end = end;
        }

        public string GetSelection()
        {   
            if (string.IsNullOrEmpty(_text) || 
                _textSelection.start == null || 
                _textSelection.end == null)
            {
                return "";
            }
            return _text.Substring(
                (int)_textSelection.start, 
                (int)(_textSelection.end - _textSelection.start ) + 1);
        }
        
        public void DeleteSelection()
        {
            if (!String.IsNullOrEmpty(GetSelection()) && 
                _textSelection.start != null &&
                _textSelection.end != null)
            {
                _text = _text.Remove(
                    (int)_textSelection.start, 
                    (int)(_textSelection.end - _textSelection.start) + 1);
                _textSelection.start = null;
                _textSelection.end = null;
            }
        }

        public void ReplaceSelection(string text)
        {
            if (_textSelection.start != null)
            {
                int selectionStart = (int)_textSelection.start;
                this.DeleteSelection();
                _text = _text.Insert(selectionStart, text);
            }
        }
    }
}
