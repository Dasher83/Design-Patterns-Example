namespace Command.Commands
{
    internal class CommandAppendPasted : Command
    {
        public CommandAppendPasted(Application app) : base(app) { }

        public override bool Execute()
        {
            SaveBackup();
            _app.Editor.Text = $"{_app.Editor.Text} {_app.Clipboard}";
            return true;
        }
    }
}
