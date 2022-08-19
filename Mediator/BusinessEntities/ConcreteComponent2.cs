using Mediator.Interfaces;
using Mediator.Utils;

namespace Mediator.BusinessEntities
{
    internal class ConcreteComponent2: Component
    {
        private readonly ConsoleColor _color;

        public ConcreteComponent2(IMediator? mediator = null) : base(mediator)
        {
            _color = RandomConsoleColorPicker.Pick;
        }

        public void DoOperationC()
        {
            RequireMediator();
            ColorConsole.WriteLine("Component 2: performing operation C.", _color);
            _mediator.Notify(this, "C");
        }

        public void DoOperationD()
        {
            RequireMediator();
            ColorConsole.WriteLine("Component 2: performing operation D.", _color);
            _mediator.Notify(this, "D");        }
    }
}
