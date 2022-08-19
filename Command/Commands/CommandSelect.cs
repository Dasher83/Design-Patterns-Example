using Command.Shared.Utils;

namespace Command.Commands
{
    internal class CommandSelect : Command
    {
        public CommandSelect(Application app) : base(app) { }

        public override bool Execute()
        {
            SaveBackup();
            int start;
            int end;
            do
            {
                start = UserInputTaker.TakeIntInput(
                    min: 0, 
                    max: _app.Editor.Text.Length - 1, 
                    prompt: "Enter the starting index of the desired selection");
                end = UserInputTaker.TakeIntInput(
                    min: start,
                    max: _app.Editor.Text.Length - 1,
                    prompt: "Enter the ending index of the desired selection");
            } while (start < 0 && end < 0);
            _app.Editor.Select(start: start, end: end);
            return true;
        }
    }
}
