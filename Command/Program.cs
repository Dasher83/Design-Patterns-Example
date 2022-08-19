using Command;
using Command.Commands;

Application app = new Application(
    commandHistory: new CommandHistory());
app.CommandExecuter = new CommandExecuter(app);
app.Run();
