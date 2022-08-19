using Observer.Interfaces;
using Observer.Utils;


namespace Observer.BusinessEntities
{
    internal class SomePublisher: IPublisher
    {
        private int _state;
        private List<ISubscriber> _subscribers;
        private ConsoleColor _color;

        public SomePublisher()
        {
            _state = 0;
            _subscribers = new List<ISubscriber>();
            _color = RandomConsoleColorPicker.Pick;
        }

        public int State { get { return _state; } set { _state = value; } }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
            ColorConsole.WriteLine("Publisher: accepted a new subscriber.", _color);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
            ColorConsole.WriteLine("Publisher: canceled an active subscription.", _color);
        }

        public void Notify()
        {
            foreach(ISubscriber subscriber in _subscribers)
            {
                subscriber.ReceiveNotification(this);
            }

            ColorConsole.WriteLine("Publisher: Notified subscribers ...", _color);
        }

        public void SomeBusinessLogic()
        {
            Console.WriteLine();
            ColorConsole.WriteLine("Publisher: I'm doing something important ...", _color);
            _state = new Random().Next(0, 10);
            Thread.Sleep(15);
            ColorConsole.WriteLine($"Publisher: My state has changed to: {_state}", _color);
            Notify();
        }
    }
}
