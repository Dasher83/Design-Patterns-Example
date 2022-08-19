using State.Utils;

namespace State.BusinessEntities
{
    internal class ConcreteStateB : State
    {
        public override void Handle1()
        {
            ColorConsole.WriteLine("ConcreteStateB handles request1.", _color);
        }

        public override void Handle2()
        {
            ColorConsole.WriteLine("ConcreteStateB handles request2.", _color);
            ColorConsole.WriteLine("ConcreteStateB wants to change the state of the context.", _color);
            _context.TransitionTo(new ConcreteStateA());
        }
    }
}
