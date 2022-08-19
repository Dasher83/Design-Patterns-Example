using Command.Shared.Utils;

namespace Command.Commands
{
    internal class CommandAppendNew : Command
    {
        public CommandAppendNew(Application app) : base(app) { }

        public override bool Execute()
        {
            do
            {
                _app.Editor.TextToAdd = UserInputTaker.TakeStringInput(
                    prompt: "Enter the new text to append: ");
            } while (String.IsNullOrEmpty(_app.Editor.TextToAdd));
            SaveBackup();
            _app.Editor.Text = $"{_app.Editor.Text} {_app.Editor.TextToAdd}";
            _app.Editor.TextToAdd = "";
            return true;
        }
    }
}
