using State.Utils;

namespace State.BusinessEntities
{
    internal class ConcreteStateA : State
    {
        public override void Handle1()
        {
            ColorConsole.WriteLine("ConcreteStateA handles request1.", _color);
            ColorConsole.WriteLine("ConcreteStateA wants to change the state of the context.", _color);
            _context.TransitionTo(new ConcreteStateB());
        }

        public override void Handle2()
        {
            ColorConsole.WriteLine("ConcreteStateA handles request2.", _color);
        }
    }
}
