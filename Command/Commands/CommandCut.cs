namespace Command.Commands
{
    internal class CommandCut : Command
    {
        public CommandCut(Application app) : base(app) { }

        public override bool Execute()
        {
            SaveBackup();
            _app.Clipboard = _app.Editor.GetSelection();
            _app.Editor.DeleteSelection();
            return true;
        }
    }
}
