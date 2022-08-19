using Mediator.BusinessEntities;

namespace Mediator.Interfaces
{
    internal interface IMediator
    {
        void Notify(Component sender, string eventName);
    }
}
