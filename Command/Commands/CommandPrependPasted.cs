namespace Command.Commands
{
    internal class CommandPrependPasted : Command
    {
        public CommandPrependPasted(Application app) : base(app) { }

        public override bool Execute()
        {
            SaveBackup();
            _app.Editor.Text = $"{_app.Clipboard} {_app.Editor.Text}";
            return true;
        }
    }
}
