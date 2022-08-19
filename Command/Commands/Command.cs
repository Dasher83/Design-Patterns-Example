using Command.Interfaces;

namespace Command.Commands
{
    internal abstract class Command : ICommand, IUndoable
    {
        protected Application _app;
        protected string _backup;

        public Command(Application app)
        {
            _app = app;
            _backup = "";
        }

        /* 
         * Returns true or false depending on whether this method
         * affects the command changes the editor's state
         */
        public abstract bool Execute();

        protected void SaveBackup()
        {
            _backup = _app.Editor.Text;
        } 

        public void Undo()
        {
            _app.Editor.Text = _backup;
        }
    }
}
