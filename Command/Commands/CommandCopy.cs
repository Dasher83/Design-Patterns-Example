namespace Command.Commands
{
    internal class CommandCopy : Command
    {
        public CommandCopy(Application app) : base(app) { }

        public override bool Execute()
        {
            _app.Clipboard = _app.Editor.GetSelection();
            Console.WriteLine("Copied!");
            Console.WriteLine();
            return false;
        }
    }
}
