using Mediator.Interfaces;
using Mediator.Utils;

namespace Mediator.BusinessEntities
{
    internal class ConcreteComponent1 : Component
    {
        private readonly ConsoleColor _color;

        public ConcreteComponent1(IMediator? mediator = null) : base(mediator)
        {
            _color = RandomConsoleColorPicker.Pick;
        }

        public void DoOperationA()
        {
            RequireMediator();
            ColorConsole.WriteLine("Component 1: performing operation A.", _color);
            _mediator.Notify(this, "A");
        }

        public void DoOperationB()
        {
            RequireMediator();
            ColorConsole.WriteLine("Component 1: performing operation B.", _color);
            _mediator.Notify(this, "B");
        }
    }
}
