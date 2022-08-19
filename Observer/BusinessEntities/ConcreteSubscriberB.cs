using Observer.Interfaces;
using Observer.Utils;


namespace Observer.BusinessEntities
{
    internal class ConcreteSubscriberB : ISubscriber
    {
        private readonly ConsoleColor _color;

        public ConcreteSubscriberB()
        {
            _color = RandomConsoleColorPicker.Pick;
        }

        public void ReceiveNotification(IPublisher publisher)
        {
            SomePublisher concretePublisher = (SomePublisher)publisher;
            
            if (concretePublisher.State == 0 || concretePublisher.State >= 2)
            {
                ColorConsole.WriteLine("ConcreteSubscriberB: Reacted to the event.", _color);
            }
        }
    }
}
