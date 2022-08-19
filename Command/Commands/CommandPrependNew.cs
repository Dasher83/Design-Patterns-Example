using Command.Shared.Utils;

namespace Command.Commands
{
    internal class CommandPrependNew : Command
    {
        public CommandPrependNew(Application app) : base(app) { }

        public override bool Execute()
        {
            do
            {
                _app.Editor.TextToAdd = UserInputTaker.TakeStringInput(
                    prompt: "Enter the new text to prepend: ");
            } while (String.IsNullOrEmpty(_app.Editor.TextToAdd));
            SaveBackup();
            _app.Editor.Text = $"{_app.Editor.TextToAdd} {_app.Editor.Text}";
            _app.Editor.TextToAdd = "";
            return true;
        }
    }
}
