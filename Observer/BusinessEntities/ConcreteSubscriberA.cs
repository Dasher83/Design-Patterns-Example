using Observer.Interfaces;
using Observer.Utils;


namespace Observer.BusinessEntities
{
    internal class ConcreteSubscriberA : ISubscriber
    {
        private readonly ConsoleColor _color;

        public ConcreteSubscriberA()
        {
            _color = RandomConsoleColorPicker.Pick;
        }

        public void ReceiveNotification(IPublisher publisher)
        {
            if (((SomePublisher)publisher).State < 3)
            {
                ColorConsole.WriteLine("ConcreteSubscriberA: Reacted to the event.", _color);
            }
        }
    }
}
