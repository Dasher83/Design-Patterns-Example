namespace Command.Commands
{
    internal class CommandUndo : Command
    {
        public CommandUndo(Application app) : base(app) { }

        public override bool Execute()
        {
            _app.Undo();
            return false;
        }
    }
}
