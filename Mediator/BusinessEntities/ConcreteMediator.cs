using Mediator.Interfaces;
using Mediator.Utils;

namespace Mediator.BusinessEntities
{
    internal class ConcreteMediator : IMediator
    {
        private readonly ConcreteComponent1 _component1;
        private readonly ConcreteComponent2 _component2;
        private readonly ConsoleColor _color;

        public ConcreteMediator(ConcreteComponent1 component1, ConcreteComponent2 component2)
        {
            _component1 = component1;
            _component1.Mediator = this;
            _component2 = component2;
            _component2.Mediator = this;
            _color = RandomConsoleColorPicker.Pick;
        }

        public void Notify(Component sender, string eventName)
        {
            switch (eventName.Trim().ToUpper())
            {
                case "A":
                    ColorConsole.WriteLine("Mediator reacts on A and triggers following operations:", _color);
                    _component2.DoOperationC();
                    break;
                case "D":
                    ColorConsole.WriteLine("Mediator reacts on D and triggers following operations:", _color);
                    _component1.DoOperationB();
                    _component2.DoOperationC();
                    break;
            }
        }
    }
}
