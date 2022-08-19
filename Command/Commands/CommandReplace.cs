namespace Command.Commands
{
    internal class CommandReplace : Command
    {
        public CommandReplace(Application app) : base(app) { }

        public override bool Execute()
        {
            SaveBackup();
            _app.Editor.ReplaceSelection(_app.Clipboard);
            return true;
        }
    }
}
