using ChainOfResponsibility.Interfaces;

namespace ChainOfResponsibility.BusinessEntities
{
    internal class AbstractHandler : IHandler
    {
        private IHandler? _next = null;
        public IHandler SetNext(IHandler next)
        {
            _next = next;
            return _next;
        }

        public virtual object? Handle(object request)
        {
            if(this._next != null)
            {
                return this._next.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
