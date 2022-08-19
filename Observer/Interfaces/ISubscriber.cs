namespace Observer.Interfaces
{
    internal interface ISubscriber
    {
        void ReceiveNotification(IPublisher publisher);
    }
}
