namespace Command.Interfaces
{
    internal interface ICommandHistory
    {
        List<Commands.Command> Commands { get; }
        void Push(Commands.Command command);
        Commands.Command? Pop();
    }
}
