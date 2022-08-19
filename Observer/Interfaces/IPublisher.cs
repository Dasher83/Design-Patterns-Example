﻿namespace Observer.Interfaces
{
    internal interface IPublisher
    {
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
        void Notify();
    }
}
